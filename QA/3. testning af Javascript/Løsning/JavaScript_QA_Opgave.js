//del1
var x = 5;
x = 5 + 7;
x = 5 + "7";
x = 5 + "7";
x = "5" + 7;
x = 5 - 7;
x = 5 - "7";
x = "5" - 7;
x = 5 - x;

document.getElementById("demo").innerHTML = x.valueOf() + " " + typeof x;
//-----------------------------------------------------------------------------
//del 2
function Check() {
var form = document.getElementsByTagName('input');
for (var i = 0; i < 3; i++) {
  if(form[i].value == "") {
    return alert("Du mangler at udfylde en af felterne");
}
}
alert("Du har sendt dine data");
}
//-----------------------------------------------------------------------------
//del 3
document.getElementById('knap').addEventListener("click",function() {
  document.getElementById('gemt').hidden = !document.getElementById('gemt').hidden;
});

//-----------------------------------------------------------------------------
//del 4
function lommeregner(){
  var tal1 = parseInt(document.getElementById("tal1").value);
  var tal2 = parseInt(document.getElementById("tal2").value);
  document.getElementById("resultat").innerHTML = tal1 + tal2
}
