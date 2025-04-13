
        // Initialize variables
        let cycleChart;
        const today = new Date();
        
        // DOM Elements
        const lastPeriodInput = document.getElementById('lastPeriod');
        const cycleLengthSlider = document.getElementById('cycleLength');
        const cycleLengthValue = document.getElementById('cycleLengthValue');
        const periodDurationSlider = document.getElementById('periodDuration');
        const periodDurationValue = document.getElementById('periodDurationValue');
        const generateBtn = document.getElementById('generatePredictions');
        
        // Result elements
        const nextPeriodDate = document.getElementById('nextPeriodDate');
        const periodCountdown = document.getElementById('periodCountdown');
        const fertilityDates = document.getElementById('fertilityDates');
        const fertilityStatus = document.getElementById('fertilityStatus');
        const cycleDay = document.getElementById('cycleDay');
        const cyclePhase = document.getElementById('cyclePhase');
        
        // Initialize the page
        document.addEventListener('DOMContentLoaded', function() {
            // Set default last period date to 28 days ago (default cycle length)
            const defaultLastPeriod = new Date();
            defaultLastPeriod.setDate(defaultLastPeriod.getDate() - 28);
            lastPeriodInput.valueAsDate = defaultLastPeriod;
            
            // Initialize sliders
            cycleLengthSlider.addEventListener('input', function() {
                cycleLengthValue.textContent = this.value;
            });
            
            periodDurationSlider.addEventListener('input', function() {
                periodDurationValue.textContent = this.value;
            });
            
            // Initialize chart
            initChart();
            
            // Generate initial predictions
            generatePredictions();
            
            // Set up event listeners
            generateBtn.addEventListener('click', generatePredictions);
            lastPeriodInput.addEventListener('change', generatePredictions);
            cycleLengthSlider.addEventListener('change', generatePredictions);
            periodDurationSlider.addEventListener('change', generatePredictions);
            
            // Mobile menu toggle
            document.querySelector('.mobile-menu-btn').addEventListener('click', function() {
                document.querySelector('.nav-links').classList.toggle('show');
            });
        });
        
        function initChart() {
            const options = {
                series: [{
                    name: 'Cycle Intensity',
                    data: generateCycleData(28, 5) // Default values
                }],
                chart: {
                    height: 300,
                    type: 'area',
                    toolbar: { show: false },
                    zoom: { enabled: false }
                },
                colors: ['#ff6b9a'],
                dataLabels: { enabled: false },
                stroke: { curve: 'smooth', width: 2 },
                fill: {
                    type: 'gradient',
                    gradient: {
                        shadeIntensity: 1,
                        opacityFrom: 0.7,
                        opacityTo: 0.3,
                        stops: [0, 90, 100]
                    }
                },
                xaxis: {
                    categories: Array.from({length: 28}, (_, i) => i+1),
                    title: { text: 'Day of Cycle' }
                },
                yaxis: {
                    min: 0,
                    max: 10,
                    title: { text: 'Intensity' }
                },
                tooltip: {
                    y: {
                        formatter: function(value) {
                            if (value < 3) return "Menstrual Phase";
                            if (value < 6) return "Follicular Phase";
                            if (value < 9) return "Ovulation Phase";
                            return "Luteal Phase";
                        }
                    }
                }
            };
            
            cycleChart = new ApexCharts(document.querySelector("#periodChart"), options);
            cycleChart.render();
        }
        
        function generateCycleData(cycleLength, periodDuration) {
            const data = [];
            // Menstrual phase (first days)
            for (let i = 0; i < periodDuration; i++) {
                data.push(Math.random() * 2 + 1); // Low intensity
            }
            
            // Follicular phase
            const follicularDays = Math.floor((cycleLength - periodDuration) * 0.4);
            for (let i = 0; i < follicularDays; i++) {
                data.push(Math.random() * 2 + 3); // Medium intensity
            }
            
            // Ovulation phase (3 days peak)
            for (let i = 0; i < 3; i++) {
                data.push(Math.random() * 2 + 7); // High intensity
            }
            
            // Luteal phase (remaining days)
            const remainingDays = cycleLength - periodDuration - follicularDays - 3;
            for (let i = 0; i < remainingDays; i++) {
                data.push(Math.random() * 2 + 5); // Medium-high intensity
            }
            
            return data;
        }
        
        function generatePredictions() {
            const lastPeriod = new Date(lastPeriodInput.value);
            const cycleLength = parseInt(cycleLengthSlider.value);
            const periodDuration = parseInt(periodDurationSlider.value);
            
            if (!lastPeriod || isNaN(lastPeriod.getTime())) {
                alert("Please enter a valid last period date");
                return;
            }
            
            // Calculate next period date
            const nextPeriod = new Date(lastPeriod);
            nextPeriod.setDate(nextPeriod.getDate() + cycleLength);
            
            // Calculate fertile window (ovulation ~14 days before next period)
            const ovulationDate = new Date(nextPeriod);
            ovulationDate.setDate(ovulationDate.getDate() - 14);
            
            const fertileStart = new Date(ovulationDate);
            fertileStart.setDate(fertileStart.getDate() - 3);
            
            const fertileEnd = new Date(ovulationDate);
            fertileEnd.setDate(fertileEnd.getDate() + 3);
            
            // Calculate days until next period
            const diffTime = nextPeriod - today;
            const diffDays = Math.ceil(diffTime / (1000 * 60 * 60 * 24));
            
            // Determine fertility status
            const isFertile = today >= fertileStart && today <= fertileEnd;
            
            // Calculate current cycle day
            const dayOfCycle = Math.floor((today - lastPeriod) / (1000 * 60 * 60 * 24)) + 1;
            
            // Determine cycle phase
            let phase;
            if (dayOfCycle <= periodDuration) {
                phase = "Menstrual Phase";
            } else if (dayOfCycle <= periodDuration + 7) {
                phase = "Follicular Phase";
            } else if (dayOfCycle <= periodDuration + 10) {
                phase = "Ovulation Phase";
            } else {
                phase = "Luteal Phase";
            }
            
            // Update UI
            nextPeriodDate.textContent = formatDate(nextPeriod);
            periodCountdown.textContent = diffDays > 0 ? `in ${diffDays} days` : "Today";
            fertilityDates.textContent = `${formatDate(fertileStart, true)} - ${formatDate(fertileEnd, true)}`;
            fertilityStatus.textContent = isFertile ? "High chance" : "Low chance";
            fertilityStatus.style.color = isFertile ? "#00b894" : "#636e72";
            cycleDay.textContent = `Day ${dayOfCycle}`;
            cyclePhase.textContent = phase;
            
            // Update exercise recommendation based on phase
            let exerciseSuggestion = "";
            if (phase === "Menstrual Phase") {
                exerciseSuggestion = "Gentle yoga and walking are recommended during your menstrual phase to help with cramps and fatigue.";
            } else if (phase === "Follicular Phase") {
                exerciseSuggestion = "This is a great time for high-intensity workouts and strength training as your energy levels rise.";
            } else if (phase === "Ovulation Phase") {
                exerciseSuggestion = "Take advantage of your peak energy with challenging workouts and endurance training.";
            } else {
                exerciseSuggestion = "Moderate exercise like pilates and light cardio can help with potential PMS symptoms during this phase.";
            }
            document.getElementById("exerciseSuggestion").textContent = exerciseSuggestion;
            
            // Update chart with new data
            cycleChart.updateSeries([{
                data: generateCycleData(cycleLength, periodDuration)
            }]);
            
            // Update x-axis categories for the new cycle length
            cycleChart.updateOptions({
                xaxis: {
                    categories: Array.from({length: cycleLength}, (_, i) => i+1)
                }
            });
        }
        
        function formatDate(date, short = false) {
            if (short) {
                return date.toLocaleDateString('en-US', { month: 'short', day: 'numeric' });
            }
            return date.toLocaleDateString('en-US', { 
                month: 'long', 
                day: 'numeric', 
                year: 'numeric' 
            });
        }
        
        function openTab(event, tabId) {
            // Hide all tab contents
            const tabContents = document.getElementsByClassName("tab-content");
            for (let i = 0; i < tabContents.length; i++) {
                tabContents[i].classList.remove("active-tab");
            }
            
            // Deactivate all tab buttons
            const tabButtons = document.getElementsByClassName("tab-btn");
            for (let i = 0; i < tabButtons.length; i++) {
                tabButtons[i].classList.remove("active");
            }
            
            // Activate the selected tab
            document.getElementById(tabId).classList.add("active-tab");
            event.currentTarget.classList.add("active");
        }
        
        function logMood() {
            const mood = document.querySelector('input[name="mood"]:checked').value;
            const symptoms = Array.from(document.querySelectorAll('input[name="symptom"]:checked'))
                                .map(el => el.value)
                                .join(", ");
            const notes = document.getElementById("notes").value;
            const date = new Date().toLocaleDateString('en-US', { 
                month: 'short', 
                day: 'numeric', 
                year: 'numeric' 
            });
            
            const moodLog = document.getElementById("moodLog");
            const logEntry = document.createElement("div");
            logEntry.className = "mood-entry";
            logEntry.innerHTML = `
                <div class="mood-entry-header">
                    <span class="mood-date">${date}</span>
                    <span class="mood-value ${mood.toLowerCase()}">
                        <i class="fas fa-${getMoodIcon(mood)}"></i> ${mood}
                    </span>
                </div>
                ${symptoms ? `<div class="mood-symptoms"><strong>Symptoms:</strong> ${symptoms}</div>` : ''}
                ${notes ? `<div class="mood-notes">${notes}</div>` : ''}
            `;
            
            moodLog.insertBefore(logEntry, moodLog.firstChild);
            
            // Clear the form
            document.getElementById("notes").value = "";
            document.querySelectorAll('input[name="symptom"]').forEach(el => el.checked = false);
        }
        
        function getMoodIcon(mood) {
            switch(mood) {
                case "Happy": return "laugh-beam";
                case "Sad": return "sad-tear";
                case "Anxious": return "flushed";
                case "Energetic": return "bolt";
                case "Tired": return "tired";
                default: return "smile";
            }
        }
        
        function predictPCOS() {
            const symptoms = document.querySelectorAll('input[name="symptom"]:checked');
            const symptomCount = symptoms.length;
            let resultText = "";
            let riskLevel = "";
            let riskPercentage = "0%";
            
            if (symptomCount >= 6) {
                resultText = "High risk of PCOS. We strongly recommend consulting with a healthcare provider for proper diagnosis and treatment options.";
                riskLevel = "high";
                riskPercentage = "90%";
            } else if (symptomCount >= 3) {
                resultText = "Moderate risk of PCOS. Consider making an appointment with your doctor to discuss your symptoms and potential next steps.";
                riskLevel = "medium";
                riskPercentage = "60%";
            } else {
                resultText = "Low risk of PCOS. However, if you have concerns about any symptoms, we recommend discussing them with your healthcare provider.";
                riskLevel = "low";
                riskPercentage = "30%";
            }
            
            // Update the risk meter
            const meterFill = document.querySelector(".meter-fill");
            meterFill.className = "meter-fill " + riskLevel;
            meterFill.style.width = riskPercentage;
            
            // Update the result text
            document.querySelector(".pcos-result-body p").innerHTML = `Based on your symptoms, your risk for PCOS appears to be <strong>${riskLevel}</strong>. ${resultText}`;
            
            // Show the result section if hidden
            document.getElementById("pcosResult").style.display = "block";
        }
  
