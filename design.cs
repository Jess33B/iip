:root{
  --primary-color:#ff6b9a;--primary-dark:#e05584;--primary-light:#ff8fb1;
  --secondary-color:#6c63ff;--accent-color:#ffb74d;--dark-color:#2d3436;
  --light-color:#f5f6fa;--gray-color:#636e72;--light-gray:#dfe6e9;
  --success-color:#00b894;--warning-color:#fdcb6e;--danger-color:#d63031;
  --info-color:#0984e3;--white:#fff;--black:#000;
  --box-shadow:0 5px 15px rgba(0,0,0,0.1);--transition:all 0.3s ease;
  --border-radius:12px;--border-radius-sm:8px;--border-radius-lg:16px
}

*,*::before,*::after{margin:0;padding:0;box-sizing:border-box}
body,h1,h2,h3,h4,h5,h6,p,a,img,ul,li{font-family:'Poppins',sans-serif;color:var(--dark-color)}
body{background-color:var(--light-color);line-height:1.6;overflow-x:hidden}
h1,h2,h3,h4,h5,h6{font-weight:600;line-height:1.2;margin-bottom:1rem}
p{margin-bottom:1rem}a{text-decoration:none}img{max-width:100%;height:auto}ul{list-style:none}

.container{width:100%;max-width:1200px;margin:0 auto;padding:0 20px}
section{padding:80px 0}.text-center{text-align:center}

/* Auth Forms */
.auth-section{
  display:flex;align-items:center;justify-content:center;min-height:100vh;
  background:linear-gradient(135deg,rgba(255,107,154,0.1) 0%,rgba(108,99,255,0.1) 100%);
  .auth-container{
    width:100%;max-width:500px;background:var(--white);padding:40px;
    border-radius:var(--border-radius-lg);box-shadow:var(--box-shadow);
    h2{text-align:center;margin-bottom:1.5rem;span{color:var(--primary-color)}}
    .form-group{margin-bottom:1.5rem}
    label{display:block;margin-bottom:0.5rem;font-weight:500}
    input{
      width:100%;padding:12px 15px;border:1px solid var(--light-gray);
      border-radius:var(--border-radius-sm);font-size:1rem;transition:var(--transition);
      &:focus{
        border-color:var(--primary-color);outline:none;
        box-shadow:0 0 0 3px rgba(255,107,154,0.2)
      }
    }
    .btn-block{margin-top:1.5rem}
    .auth-footer{
      text-align:center;margin-top:1.5rem;font-size:0.9rem;
      a{color:var(--primary-color);font-weight:500}
    }
  }
}

.section-header{
  text-align:center;margin-bottom:50px;
  h2{font-size:2.5rem;span{color:var(--primary-color)}}
  p{color:var(--gray-color);max-width:700px;margin:0 auto}
}

.btn {
  display: inline-block;
  padding: 12px 24px;
  border-radius: var(--border-radius);
  font-weight: 500;
  text-align: center;
  transition: var(--transition);
  cursor: pointer;
  border: none;
  font-size: 1rem;
  background-color: var(--primary-color); /* Added this line */
  color: var(--white); /* Ensure text is readable */
}

.main-header{
  position:fixed;top:0;left:0;width:100%;background-color:var(--white);
  box-shadow:0 2px 10px rgba(0,0,0,0.1);z-index:1000;padding:15px 0;
  .logo-container{display:flex;align-items:center}
  .logo-icon{font-size:1.8rem;color:var(--primary-color);margin-right:10px}
  .logo-text{font-size:1.5rem;font-weight:700;span{color:var(--primary-color)}}
  .main-nav{display:flex;align-items:center;justify-content:space-between}
  .nav-links{
    display:flex;align-items:center;gap:25px;
    a{
      font-weight:500;transition:var(--transition);display:flex;align-items:center;gap:5px;
      &:hover,&.active{color:var(--primary-color)}.active{font-weight:600}
    }
  }
  .mobile-menu-btn{display:none;font-size:1.5rem;cursor:pointer}
}

.hero-section{
  padding:150px 0 100px;background:linear-gradient(135deg,#fff0f6 0%,#f8f9fa 100%);
  position:relative;overflow:hidden;
  .hero-content{
    max-width:600px;
    h1{font-size:3rem;margin-bottom:1.5rem;line-height:1.2;span{color:var(--primary-color)}}
    .hero-subtitle{font-size:1.1rem;color:var(--gray-color);margin-bottom:2rem}
    .hero-buttons{display:flex;gap:15px;margin-bottom:3rem}
    .hero-stats{display:flex;gap:30px;margin-top:2rem}
    .stat-item{text-align:center}
    .stat-number{font-size:2rem;font-weight:700;color:var(--primary-color);line-height:1;margin-bottom:5px}
    .stat-label{font-size:0.9rem;color:var(--gray-color)}
  }
  .hero-image{
    position:absolute;right:0;top:50%;transform:translateY(-50%);width:50%;max-width:600px;
    border-radius:var(--border-radius-lg);overflow:hidden;box-shadow:var(--box-shadow);
    img{width:100%;height:auto;display:block}
  }
  .floating-card{
    position:absolute;background:var(--white);border-radius:var(--border-radius);
    padding:15px;box-shadow:var(--box-shadow);animation:float 6s ease-in-out infinite;
    &.cycle-card{
      top:20px;left:20px;background:linear-gradient(135deg,var(--primary-color) 0%,var(--secondary-color) 100%);
      color:var(--white);text-align:center;width:120px;
      .cycle-day{font-size:2rem;font-weight:700;line-height:1}
      .cycle-phase{font-size:0.9rem;opacity:0.9}
    }
    &.symptom-card{
      bottom:30px;right:30px;width:180px;
      .symptom-title{font-weight:600;margin-bottom:10px}
      .symptom-items{
        display:flex;flex-wrap:wrap;gap:8px;
        span{
          background-color:var(--light-color);padding:5px 10px;border-radius:20px;
          font-size:0.8rem;display:flex;align-items:center;gap:5px
        }
      }
    }
  }
}

.features-section,.insights-section{background-color:var(--white)}
.tracker-section,.testimonials-section{background-color:#f9f9f9}

.features-grid,.exercise-grid,.nutrition-grid,.testimonials-slider{
  display:grid;gap:30px;grid-template-columns:repeat(auto-fit,minmax(250px,1fr))
}

.feature-card,.exercise-card,.nutrition-card,.testimonial-card{
  background-color:var(--white);border-radius:var(--border-radius);transition:var(--transition);
  &:hover{transform:translateY(-5px);box-shadow:0 10px 25px rgba(0,0,0,0.1)}
}
.feature-card{padding:30px;box-shadow:var(--box-shadow);border:1px solid var(--light-gray)}
.exercise-card{overflow:hidden;box-shadow:0 5px 15px rgba(0,0,0,0.05)}
.nutrition-card{padding:25px;text-align:center;box-shadow:0 5px 15px rgba(0,0,0,0.05)}
.testimonial-card{padding:30px;box-shadow:var(--box-shadow)}

.feature-icon,.nutrition-icon{
  width:60px;height:60px;border-radius:50%;display:flex;align-items:center;justify-content:center;
  margin:0 auto 15px;font-size:1.5rem
}
.feature-icon{
  background:linear-gradient(135deg,var(--primary-color) 0%,var(--secondary-color) 100%);color:var(--white)
}
.nutrition-icon{background-color:var(--light-color);color:var(--primary-color)}

.feature-card h3,.exercise-info h4,.nutrition-card h4{font-size:1.2rem;margin-bottom:15px}
.feature-card p,.exercise-info p,.nutrition-card p{color:var(--gray-color);margin-bottom:20px}
.feature-link{
  color:var(--primary-color);font-weight:500;display:flex;align-items:center;gap:5px;
  &:hover{color:var(--primary-dark);gap:10px}
}

.tracker-container{
  display:grid;grid-template-columns:1fr 1fr;gap:40px;align-items:center;
  .tracker-form{
    background-color:var(--white);padding:40px;border-radius:var(--border-radius-lg);box-shadow:var(--box-shadow);
    h2{font-size:2rem;margin-bottom:1rem;span{color:var(--primary-color)}}
    .section-subtitle{color:var(--gray-color);margin-bottom:2rem}
  }
  .advanced-form{
    .form-group{margin-bottom:20px}
    label{
      display:block;margin-bottom:8px;font-weight:500;display:flex;align-items:center;gap:8px
    }
    input[type="date"],input[type="text"],input[type="number"],select,textarea{
      width:100%;padding:12px 15px;border:1px solid var(--light-gray);border-radius:var(--border-radius-sm);
      font-size:1rem;transition:var(--transition);
      &:focus{
        border-color:var(--primary-color);outline:none;box-shadow:0 0 0 3px rgba(255,107,154,0.2)
      }
    }
    .range-container{
      display:flex;align-items:center;gap:15px;
      input[type="range"]{
        flex:1;-webkit-appearance:none;height:8px;background:var(--light-gray);border-radius:5px;outline:none;
        &::-webkit-slider-thumb{
          -webkit-appearance:none;appearance:none;width:20px;height:20px;background:var(--primary-color);
          border-radius:50%;cursor:pointer;transition:var(--transition);
          &:hover{background:var(--primary-dark);transform:scale(1.1)}
        }
      }
      span{min-width:30px;text-align:center;font-weight:600;color:var(--primary-color)}
    }
  }
}

.tracker-results{
  display:flex;flex-direction:column;gap:30px;
  .prediction-card{
    background:linear-gradient(135deg,var(--primary-color) 0%,var(--secondary-color) 100%);
    border-radius:var(--border-radius-lg);padding:30px;color:var(--white);box-shadow:var(--box-shadow);
    .prediction-header{
      display:flex;justify-content:space-between;align-items:center;margin-bottom:25px;
      h3{color:var(--white);margin-bottom:0}
      .prediction-accuracy{
        background-color:rgba(255,255,255,0.2);padding:5px 10px;border-radius:20px;
        font-size:0.8rem;font-weight:600
      }
    }
    .prediction-body{
      display:grid;grid-template-columns:1fr 1fr;gap:20px;margin-bottom:25px;
      .next-period,.fertility-window{
        text-align:center;
        .period-label,.fertility-label{font-size:0.9rem;opacity:0.8;margin-bottom:5px}
        .period-date,.fertility-dates{font-size:1.2rem;font-weight:600;margin-bottom:5px}
        .period-countdown,.fertility-status{font-size:0.9rem;opacity:0.9}
      }
    }
    .prediction-footer{display:flex;justify-content:center}
    .cycle-day{
      text-align:center;background-color:rgba(255,255,255,0.15);padding:15px 25px;border-radius:var(--border-radius);
      .day-label{font-size:0.8rem;opacity:0.8;margin-bottom:3px}
      .day-number{font-size:1.8rem;font-weight:700;line-height:1}
      .phase-name{font-size:0.9rem;opacity:0.9}
    }
  }
  .chart-container{
    background-color:var(--white);padding:20px;border-radius:var(--border-radius-lg);box-shadow:var(--box-shadow)
  }
}

.insights-tabs{
  background-color:var(--white);border-radius:var(--border-radius-lg);box-shadow:var(--box-shadow);overflow:hidden;
  .tab-header{
    display:flex;border-bottom:1px solid var(--light-gray);
    .tab-btn{
      padding:15px 25px;background:none;border:none;cursor:pointer;font-weight:500;color:var(--gray-color);
      transition:var(--transition);display:flex;align-items:center;gap:8px;position:relative;
      &:hover{color:var(--primary-color)}
      &.active{
        color:var(--primary-color);font-weight:600;
        &::after{
          content:'';position:absolute;bottom:-1px;left:0;width:100%;height:3px;background-color:var(--primary-color)
        }
      }
    }
  }
  .tab-content{
    display:none;padding:30px;&.active-tab{display:block}
  }
}

.recommendation-card,.mood-tracker,.pcos-checker{
  background-color:var(--light-color);border-radius:var(--border-radius)
}
.recommendation-card{
  overflow:hidden;
  .recommendation-header{
    padding:20px;background:linear-gradient(135deg,var(--primary-color) 0%,var(--secondary-color) 100%);
    color:var(--white);display:flex;justify-content:space-between;align-items:center;
    h3{color:var(--white);margin-bottom:0}
    .intensity-level{
      display:flex;align-items:center;gap:8px;font-size:0.9rem;
      .stars{display:flex;gap:2px;color:var(--accent-color)}
    }
  }
  .recommendation-body{
    padding:30px;
    p{margin-bottom:25px;font-size:1.1rem;line-height:1.6}
  }
}

.exercise-grid{gap:25px}
.exercise-image{height:180px;background-size:cover;background-position:center}
.exercise-info{padding:20px}
.exercise-meta{display:flex;justify-content:space-between;font-size:0.8rem;color:var(--gray-color)}

.mood-tracker{
  padding:30px;
  h3{display:flex;align-items:center;gap:10px;margin-bottom:25px}
  .mood-form{margin-bottom:30px}
  .mood-options{
    display:flex;gap:10px;margin-bottom:20px;
    .mood-option{
      flex:1;text-align:center;padding:15px;border-radius:var(--border-radius-sm);
      background-color:var(--white);cursor:pointer;transition:var(--transition);border:2px solid transparent;
      i{font-size:1.5rem;margin-bottom:5px;display:block}
      &.happy i{color:#00b894}
      &.sad i{color:#0984e3}
      &.anxious i{color:#fdcb6e}
      &.energetic i{color:#e17055}
      &.tired i{color:#636e72}
    }
  }
  input[type="radio"]:checked+.mood-option{
    border-color:var(--primary-color);background-color:rgba(255,107,154,0.1)
  }
  .symptom-options{
    display:flex;flex-wrap:wrap;gap:10px;margin-bottom:20px;
    .symptom-option{
      padding:8px 15px;background-color:var(--white);border-radius:20px;font-size:0.9rem;
      cursor:pointer;transition:var(--transition);border:1px solid var(--light-gray)
    }
  }
  input[type="checkbox"]:checked+.symptom-option{
    background-color:var(--primary-color);color:var(--white);border-color:var(--primary-color)
  }
  textarea{
    width:100%;min-height:100px;padding:15px;border:1px solid var(--light-gray);
    border-radius:var(--border-radius-sm);font-family:inherit;resize:vertical
  }
  .mood-history{margin-top:30px}
  .mood-log{max-height:300px;overflow-y:auto;padding-right:10px}
  .mood-entry{
    background-color:var(--white);padding:15px;border-radius:var(--border-radius-sm);margin-bottom:10px;
    .mood-entry-header{
      display:flex;justify-content:space-between;align-items:center;margin-bottom:8px;
      .mood-date{font-size:0.8rem;color:var(--gray-color)}
      .mood-value{
        display:flex;align-items:center;gap:5px;font-weight:500;
        &.happy{color:#00b894}
        &.sad{color:#0984e3}
        &.anxious{color:#fdcb6e}
        &.energetic{color:#e17055}
        &.tired{color:#636e72}
      }
    }
    .mood-symptoms{font-size:0.9rem;margin-bottom:8px;color:var(--gray-color)}
    .mood-notes{font-size:0.9rem;color:var(--dark-color);line-height:1.5}
  }
}

.pcos-checker{
  padding:30px;
  h3{display:flex;align-items:center;gap:10px;margin-bottom:15px}
  p{margin-bottom:25px;color:var(--gray-color)}
  .pcos-options{
    display:grid;grid-template-columns:repeat(auto-fit,minmax(200px,1fr));gap:15px;margin-bottom:25px;
    .pcos-option{
      background-color:var(--white);padding:15px;border-radius:var(--border-radius-sm);
      display:flex;align-items:center;gap:10px;cursor:pointer;transition:var(--transition);
      border:1px solid var(--light-gray);
      &:hover{border-color:var(--primary-color)}
      i{color:var(--primary-color);font-size:1.2rem}
    }
  }
  input[type="checkbox"]:checked+label.pcos-option{
    background-color:rgba(255,107,154,0.1);border-color:var(--primary-color)
  }
  .pcos-result{
    background-color:var(--white);border-radius:var(--border-radius);padding:25px;
    margin-top:30px;box-shadow:0 5px 15px rgba(0,0,0,0.05);display:none;
    .pcos-result-header{
      display:flex;justify-content:space-between;align-items:center;margin-bottom:20px;
      .risk-meter{
        width:200px;height:10px;background-color:var(--light-gray);border-radius:5px;
        position:relative;overflow:hidden;
        .meter-fill{
          position:absolute;left:0;top:0;height:100%;border-radius:5px;transition:width 0.5s ease;
          &.low{width:30%;background-color:var(--success-color)}
          &.medium{width:60%;background-color:var(--warning-color)}
          &.high{width:90%;background-color:var(--danger-color)}
        }
      }
      .meter-labels{
        display:flex;justify-content:space-between;margin-top:5px;font-size:0.8rem;color:var(--gray-color)
      }
    }
    .pcos-result-body p{margin-bottom:20px;line-height:1.6}
    .pcos-actions{display:flex;gap:15px;margin-top:25px}
  }
}

.testimonial-content{
  margin-bottom:25px;
  .rating{color:var(--accent-color);margin-bottom:15px}
  p{font-style:italic;color:var(--gray-color);line-height:1.6}
}
.testimonial-author{
  display:flex;align-items:center;gap:15px;
  img{width:50px;height:50px;border-radius:50%;object-fit:cover}
  .author-info h4{font-size:1rem;margin-bottom:3px}
  .author-info span{font-size:0.8rem;color:var(--gray-color)}
}

.cta-section{
  background:linear-gradient(135deg,var(--primary-color) 0%,var(--secondary-color) 100%);
  color:var(--white);text-align:center;padding:100px 0;
  h2{
    font-size:2.5rem;margin-bottom:1.5rem;
    span{
      color:var(--white);position:relative;
      &::after{
        content:'';position:absolute;bottom:5px;left:0;width:100%;height:3px;background-color:var(--accent-color)
      }
    }
  }
  p{font-size:1.1rem;max-width:700px;margin:0 auto 2.5rem;opacity:0.9}
  .cta-buttons{
    display:flex;justify-content:center;gap:20px;
    .btn-outline{
      color:var(--white);border-color:var(--white);
      &:hover{background-color:var(--white);color:var(--primary-color)}
    }
  }
}

.main-footer{
  background-color:var(--dark-color);color:var(--light-gray);padding:80px 0 0;
  .footer-grid{
    display:grid;grid-template-columns:repeat(auto-fit,minmax(200px,1fr));gap:40px;margin-bottom:50px;
    .footer-about{
      .logo-text{color:var(--white)}
      p{margin:20px 0;font-size:0.9rem;line-height:1.6}
      .social-links{
        display:flex;gap:15px;
        a{
          width:40px;height:40px;background-color:rgba(255,255,255,0.1);border-radius:50%;
          display:flex;align-items:center;justify-content:center;transition:var(--transition);
          &:hover{background-color:var(--primary-color);transform:translateY(-3px)}
        }
      }
    }
    .footer-links,.footer-newsletter{
      h4{
        color:var(--white);font-size:1.1rem;margin-bottom:20px;position:relative;padding-bottom:10px;
        &::after{
          content:'';position:absolute;bottom:0;left:0;width:40px;height:2px;background-color:var(--primary-color)
        }
      }
      ul li{
        margin-bottom:10px;
        a{
          font-size:0.9rem;transition:var(--transition);
          &:hover{color:var(--primary-color);padding-left:5px}
        }
      }
    }
    .footer-newsletter{
      p{font-size:0.9rem;margin-bottom:20px;line-height:1.6}
      input{
        width:100%;padding:12px 15px;border:none;border-radius:var(--border-radius-sm);
        margin-bottom:10px;font-size:0.9rem
      }
    }
  }
  .footer-bottom{
    border-top:1px solid rgba(255,255,255,0.1);padding:20px 0;
    display:flex;justify-content:space-between;align-items:center;font-size:0.8rem;
    .legal-links{
      display:flex;gap:15px;
      a{transition:var(--transition);&:hover{color:var(--primary-color)}}
  }
}



@media (max-width:992px){
  .hero-image{position:relative;width:100%;max-width:100%;transform:none;margin-top:50px}
  .hero-content{max-width:100%;text-align:center}
  .hero-buttons,.hero-stats{justify-content:center}
  .tracker-container{grid-template-columns:1fr}
}

@media (max-width:768px){
  .nav-links{display:none;flex-direction:column;position:absolute;top:100%;left:0;width:100%;
    background-color:var(--white);padding:20px;box-shadow:0 5px 10px rgba(0,0,0,0.1)}
  .nav-links.show{display:flex}
  .mobile-menu-btn{display:block}
  .hero-content h1{font-size:2.5rem}
  section{padding:60px 0}
  .section-header h2,.cta-section h2{font-size:2rem}
  .footer-grid{grid-template-columns:1fr 1fr}
}

@media (max-width:576px){
  .hero-content h1{font-size:2rem}
  .hero-buttons,.cta-buttons{flex-direction:column}
  .footer-grid{grid-template-columns:1fr}
  .footer-bottom{flex-direction:column;gap:15px;text-align:center}
  .legal-links{justify-content:center}
}
