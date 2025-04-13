# iip
# PeriodPal Flask App

PeriodPal is a Flask-based web application for tracking menstrual cycles, providing insights, and managing personal health more effectively.

## Project Structure

The main directories and files are as follows:

- [run.py](run.py): Entry point for running the Flask application.  
- [requirements.txt](requirements.txt): Lists the required Python packages.  
- [config.py](config.py): Contains the Flask configuration (database URI, email settings, secret key, etc.).  
- [app/__init__.py](app/__init__.py): Defines the [`create_app`](app/__init__.py) factory function to set up the Flask application.  
- [app/models.py](app/models.py): Defines SQLAlchemy models like [`User`](app/models.py) and [`Post`](app/models.py).  
- [app/auth](app/auth): Contains user authentication-related routes, forms, and templates.  
- [app/main](app/main): Holds the main blueprint with routes, templates for home, about, and contact pages.  
- [app/static](app/static): Static files (CSS, JS, images).  
- [app/templates](app/templates): Base templates and shared HTML files.

```
periodpal/
└── flask-app/
    ├── run.py
    ├── requirements.txt
    ├── config.py
    ├── app/
    │   ├── __init__.py
    │   ├── models.py
    │   ├── auth/
    │   ├── main/
    │   ├── static/
    │   └── templates/
    └── README.md
```

## Installation

1. Clone or download the repository.  
2. Navigate to the `periodpal/flask-app` directory.  
3. Install dependencies:
   ```sh
   pip install -r requirements.txt
   ```
4. (Optional) Update your configuration in [config.py](config.py) for database settings, email credentials, and secret keys.

## Usage

1. Navigate to `periodpal/flask-app`.  
2. Run the Flask app:
   ```sh
   python run.py
   ```
3. Open your web browser at http://127.0.0.1:5000 to access PeriodPal.

## Features

- User Authentication: Register, login, and password reset in the [auth](app/auth) module.  
- Main Pages: Home, about, and contact routes in the [main](app/main) module.  
- Database Models: Defined in [models.py](app/models.py) using SQLAlchemy.  
- Templates: Organized into `auth/templates`, `main/templates`, and shared layouts in `app/templates/`.  
- Static Resources: Stored under [app/static](app/static) for CSS and JavaScript.

## Customization

- Modify the styling in [style.css](app/static/css/style.css).  
- Extend or change the HTML structure in the templates (`home.html`, `about.html`, etc.).  
- Add more routes and forms as needed.

## Contributing

Feel free to fork this project and make pull requests. For major changes, please open an issue first to discuss what you would like to change.
