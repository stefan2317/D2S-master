function vermais() {
    var text = document.getElementById("vermais").innerHTML;
    if (text == "Ver mais") {
        document.getElementById("contentchild3escondido").style.display = "flex";
        document.getElementById("vermais").innerHTML = "Ver menos";
    }
    else if (text == "Ver menos") {
        document.getElementById("contentchild3escondido").style.display = "none";
        document.getElementById("quinto").style.display = "none";
        document.getElementById("mais5").innerHTML = "+";
        document.getElementById("vermais").innerHTML = "Ver mais";
    }      
}

function vermais2() {
    var text = document.getElementById("vermais2").innerHTML;
    if (text == "Ver mais") {
        document.getElementById("contentchild32escondido").style.display = "flex";
        document.getElementById("contentchild32escondido2").style.display = "flex";
        document.getElementById("vermais2").innerHTML = "Ver menos";
    }
    else if (text == "Ver menos") {
        document.getElementById("contentchild32escondido").style.display = "none";
        document.getElementById("contentchild32escondido2").style.display = "none";
        document.getElementById("decimoprimeiro").style.display = "none";
        document.getElementById("mais11").innerHTML = "+";
        document.getElementById("decimosegundo").style.display = "none";
        document.getElementById("mais12").innerHTML = "+";
        document.getElementById("vermais2").innerHTML = "Ver mais";
    }
}


/*botoes de mais e menos*/
    $(document).ready(function () {
    //primeirooooooooooooooooooooooooooooooooooooooooooooooooooooooooo
    $("#mais1").click(function () {
        var text = document.getElementById("mais1").innerHTML.trim();
    if (text == "+") {
        $("#primeiro").slideDown("slow");
        document.getElementById("mais1").innerHTML = "-";
    }
     else {
        $("#primeiro").slideUp("slow");
        document.getElementById("mais1").innerHTML = "+";
    }
    });
   //////////////////////////////////////////////////////////////////

    //segundoooooooooooooooooooooooooooooooooooooooooooooooooooooooo
    $("#mais2").click(function () {
        var text = document.getElementById("mais2").innerHTML.trim();
        if (text == "+") {
            $("#segundo").slideDown("slow");
            document.getElementById("mais2").innerHTML = "-";
        }
        else {
            $("#segundo").slideUp("slow");
            document.getElementById("mais2").innerHTML = "+";
        }
    });
   //////////////////////////////////////////////////////////////////

    //terceirooooooooooooooooooooooooooooooooooooooooooooooooooooooo
    $("#mais3").click(function () {
        var text = document.getElementById("mais3").innerHTML.trim();
        if (text == "+") {
            $("#terceiro").slideDown("slow");
            document.getElementById("mais3").innerHTML = "-";
        }
        else {
            $("#terceiro").slideUp("slow");
            document.getElementById("mais3").innerHTML = "+";
        }
    });
   //////////////////////////////////////////////////////////////////

    //quartoooooooooooooooooooooooooooooooooooooooooooooooooooooooooo
    $("#mais4").click(function () {
        var text = document.getElementById("mais4").innerHTML.trim();
        if (text == "+") {
            $("#quarto").slideDown("slow");
            document.getElementById("mais4").innerHTML = "-";
        }
        else {
            $("#quarto").slideUp("slow");
            document.getElementById("mais4").innerHTML = "+";
        }
    });
   //////////////////////////////////////////////////////////////////

    //quintooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo
        $("#mais5").click(function () {
            var text = document.getElementById("mais5").innerHTML.trim();
            if (text == "+") {
                $("#quinto").slideDown("slow");
                document.getElementById("mais5").innerHTML = "-";
            }
            else {
                $("#quinto").slideUp("slow");
                document.getElementById("mais5").innerHTML = "+";
            }
        });
   //////////////////////////////////////////////////////////////////

    //sextooooooooooooooooooooooooooooooooooooooooooooooooooooooooo
        $("#mais6").click(function () {
            var text = document.getElementById("mais6").innerHTML.trim();
            if (text == "+") {
                $("#sexto").slideDown("slow");
                document.getElementById("mais6").innerHTML = "-";
            }
            else {
                $("#sexto").slideUp("slow");
                document.getElementById("mais6").innerHTML = "+";
            }
        });
   //////////////////////////////////////////////////////////////////

    //setimoooooooooooooooooooooooooooooooooooooooooooooooooooooooooo
        $("#mais7").click(function () {
            var text = document.getElementById("mais7").innerHTML.trim();
            if (text == "+") {
                $("#setimo").slideDown("slow");
                document.getElementById("mais7").innerHTML = "-";
            }
            else {
                $("#setimo").slideUp("slow");
                document.getElementById("mais7").innerHTML = "+";
            }
        });
   //////////////////////////////////////////////////////////////////

    //oitavoooooooooooooooooooooooooooooooooooooooooooooooooooooooo
        $("#mais8").click(function () {
            var text = document.getElementById("mais8").innerHTML.trim();
            if (text == "+") {
                $("#oitavo").slideDown("slow");
                document.getElementById("mais8").innerHTML = "-";
            }
            else {
                $("#oitavo").slideUp("slow");
                document.getElementById("mais8").innerHTML = "+";
            }
        });
   //////////////////////////////////////////////////////////////////

        //nonooooooooooooooooooooooooooooooooooooooooooooooooooooooo
        $("#mais9").click(function () {
            var text = document.getElementById("mais9").innerHTML.trim();
            if (text == "+") {
                $("#nono").slideDown("slow");
                document.getElementById("mais9").innerHTML = "-";
            }
            else {
                $("#nono").slideUp("slow");
                document.getElementById("mais9").innerHTML = "+";
            }
        });
   //////////////////////////////////////////////////////////////////

        //decimoooooooooooooooooooooooooooooooooooooooooooooooooooooo
        $("#mais10").click(function () {
            var text = document.getElementById("mais10").innerHTML.trim();
            if (text == "+") {
                $("#decimo").slideDown("slow");
                document.getElementById("mais10").innerHTML = "-";
            }
            else {
                $("#decimo").slideUp("slow");
                document.getElementById("mais10").innerHTML = "+";
            }
        });
   //////////////////////////////////////////////////////////////////

        //decimoprimeiroooooooooooooooooooooooooooooooooooooooooooooo
        $("#mais11").click(function () {
            var text = document.getElementById("mais11").innerHTML.trim();
            if (text == "+") {
                $("#decimoprimeiro").slideDown("slow");
                document.getElementById("mais11").innerHTML = "-";
            }
            else {
                $("#decimoprimeiro").slideUp("slow");
                document.getElementById("mais11").innerHTML = "+";
            }
        });
   //////////////////////////////////////////////////////////////////

        //decimosegundoooooooooooooooooooooooooooooooooooooooooooooo
        $("#mais12").click(function () {
            var text = document.getElementById("mais12").innerHTML.trim();
            if (text == "+") {
                $("#decimosegundo").slideDown("slow");
                document.getElementById("mais12").innerHTML = "-";
            }
            else {
                $("#decimosegundo").slideUp("slow");
                document.getElementById("mais12").innerHTML = "+";
            }
        });
   //////////////////////////////////////////////////////////////////

        //decimoterceiroooooooooooooooooooooooooooooooooooooooooooooooooo
        $("#mais13").click(function () {
            var text = document.getElementById("mais13").innerHTML.trim();
            if (text == "+") {
                $("#decimoterceiro").slideDown("slow");
                document.getElementById("mais13").innerHTML = "-";
            }
            else {
                $("#decimoterceiro").slideUp("slow");
                document.getElementById("mais13").innerHTML = "+";
            }
        });
   //////////////////////////////////////////////////////////////////

        //decimoquartoooooooooooooooooooooooooooooooooooooooooooooooo
        $("#mais14").click(function () {
            var text = document.getElementById("mais14").innerHTML.trim();
            if (text == "+") {
                $("#decimoquarto").slideDown("slow");
                document.getElementById("mais14").innerHTML = "-";
            }
            else {
                $("#decimoquarto").slideUp("slow");
                document.getElementById("mais14").innerHTML = "+";
            }
        });
   //////////////////////////////////////////////////////////////////

        //decimoquintoooooooooooooooooooooooooooooooooooooooooooooooooo
        $("#mais15").click(function () {
            var text = document.getElementById("mais15").innerHTML.trim();
            if (text == "+") {
                $("#decimoquinto").slideDown("slow");
                document.getElementById("mais15").innerHTML = "-";
            }
            else {
                $("#decimoquinto").slideUp("slow");
                document.getElementById("mais15").innerHTML = "+";
            }
        });
   //////////////////////////////////////////////////////////////////

        //decimosextoooooooooooooooooooooooooooooooooooooooooooooooooo
        $("#mais16").click(function () {
            var text = document.getElementById("mais16").innerHTML.trim();
            if (text == "+") {
                $("#decimosexto").slideDown("slow");
                document.getElementById("mais16").innerHTML = "-";
            }
            else {
                $("#decimosexto").slideUp("slow");
                document.getElementById("mais16").innerHTML = "+";
            }
        });
   //////////////////////////////////////////////////////////////////

        //decimosetimoooooooooooooooooooooooooooooooooooooooooooooooo
        $("#mais17").click(function () {
            var text = document.getElementById("mais17").innerHTML.trim();
            if (text == "+") {
                $("#decimosetimo").slideDown("slow");
                document.getElementById("mais17").innerHTML = "-";
            }
            else {
                $("#decimosetimo").slideUp("slow");
                document.getElementById("mais17").innerHTML = "+";
            }
        });
   //////////////////////////////////////////////////////////////////

        //decimooitavoooooooooooooooooooooooooooooooooooooooooooooooooo
        $("#mais18").click(function () {
            var text = document.getElementById("mais18").innerHTML.trim();
            if (text == "+") {
                $("#decimooitavo").slideDown("slow");
                document.getElementById("mais18").innerHTML = "-";
            }
            else {
                $("#decimooitavo").slideUp("slow");
                document.getElementById("mais18").innerHTML = "+";
            }
        });
   //////////////////////////////////////////////////////////////////

        //decimononooooooooooooooooooooooooooooooooooooooooooooooooooo
        $("#mais19").click(function () {
            var text = document.getElementById("mais19").innerHTML.trim();
            if (text == "+") {
                $("#decimonono").slideDown("slow");
                document.getElementById("mais19").innerHTML = "-";
            }
            else {
                $("#decimonono").slideUp("slow");
                document.getElementById("mais19").innerHTML = "+";
            }
        });
   //////////////////////////////////////////////////////////////////

});


/*escolha de cabecalho*/
function um() {
    document.getElementById("um").style.backgroundColor = "White";
    document.getElementById("dois").style.backgroundColor = "rgb(241, 243, 244)";
    document.getElementById("tres").style.backgroundColor = "rgb(241, 243, 244)";
    document.getElementById("quatro").style.backgroundColor = "rgb(241, 243, 244)";

    document.getElementById("conta").style.display = "flex";
    document.getElementById("pagamento").style.display = "none";
    document.getElementById("envio").style.display = "none";
    document.getElementById("tracking").style.display = "none";
 
}

function dois() {
    document.getElementById("um").style.backgroundColor = "rgb(241, 243, 244)";
    document.getElementById("dois").style.backgroundColor = "White";
    document.getElementById("tres").style.backgroundColor = "rgb(241, 243, 244)";
    document.getElementById("quatro").style.backgroundColor = "rgb(241, 243, 244)";

    document.getElementById("conta").style.display = "none";
    document.getElementById("pagamento").style.display = "flex";
    document.getElementById("envio").style.display = "none";
    document.getElementById("tracking").style.display = "none";

}

function tres() {
    document.getElementById("um").style.backgroundColor = "rgb(241, 243, 244)";
    document.getElementById("dois").style.backgroundColor = "rgb(241, 243, 244)";
    document.getElementById("tres").style.backgroundColor = "White";
    document.getElementById("quatro").style.backgroundColor = "rgb(241, 243, 244)";

    document.getElementById("conta").style.display = "none";
    document.getElementById("pagamento").style.display = "none";
    document.getElementById("envio").style.display = "flex";
    document.getElementById("tracking").style.display = "none";

}

function quatro() {
    document.getElementById("um").style.backgroundColor = "rgb(241, 243, 244)";
    document.getElementById("dois").style.backgroundColor = "rgb(241, 243, 244)";
    document.getElementById("tres").style.backgroundColor = "rgb(241, 243, 244)";
    document.getElementById("quatro").style.backgroundColor = "White";

    document.getElementById("conta").style.display = "none";
    document.getElementById("pagamento").style.display = "none";
    document.getElementById("envio").style.display = "none";
    document.getElementById("tracking").style.display = "flex";

}
