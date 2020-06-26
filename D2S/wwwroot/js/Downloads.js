
                function func1() {
            document.getElementById("desktop").style.zIndex = +1;
                    document.getElementById("dispositivos").style.display = "none";
                    document.getElementById("desktop").style.display = "block";
                }

                function func2() {
            document.getElementById("telemovel").style.zIndex = +1;
                    document.getElementById("dispositivos").style.display = "none";
                    document.getElementById("telemovel").style.display = "block";
                }

                function func3() {
            document.getElementById("desktop").style.zIndex = -1;
                    document.getElementById("dispositivos").style.display = "block";
                    document.getElementById("desktop").style.display = "none";
                }

                function func4() {
            document.getElementById("telemovel").style.zIndex = -1;
                    document.getElementById("dispositivos").style.display = "block";
                    document.getElementById("telemovel").style.display = "none";
                }

function nav() {
    document.getElementById("span").style.top = "-50%";
}