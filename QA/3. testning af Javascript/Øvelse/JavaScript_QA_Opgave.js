<!DOCTYPE html>
<html>
<body>

<p>Find fejlen og vis tallet 7 </p>

<p id="demo"></p>

<hr>
<p>Find fejlen så der kommer en alert op der skriver om man har udfyldt formen eller ej</p>
<form onsubmit="Check" id="submit" method="get">
  <label for="Navn">Navn</label>
  <input type="text" name="Navn" value="">
  <br>
  <label for="Mail">Mail</label>
  <input type="text" name="Mail" value="">
  <br>
  <label for="Password">Kode</label>
  <input type="password" name="Password" value="">
  <br>
  <input type="submit" name="" value="Indsend">
</form>

<hr>
<p>Gør så knappen viser paragrafen med id "gemt"</p>
<input type="button" id="knap" name="knap" value="Klik mig">
<p id="gemt" hidden="true">Jeg er gemt :)</p>

<script>

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

function Check() {
var form = document.getElementsByTagName('input');
for (var i = 0; i < form.length; i++) {
  if(form[i].value == "") {
    return alert("Du mangler at udfylde en af felterne");
}
}
alert("Du har sendt dine data");
}

document.getElementById('knap').addEventListener("click",function() {
  document.getElementById('gemt').hidden = !document.getElementById('gemt').hidden;
});

</script>
</body>
</html>
