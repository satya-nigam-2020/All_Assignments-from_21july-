var myInput = document.getElementById("formGroupExampleInput");

var input2=document.getElementById("psw");

myInput.onfocus=function()
{

if(myInput.value.length >= 3) {
    length.classList.remove("invalid");
    length.classList.add("valid");
  } else {
    length.classList.remove("valid");
    length.classList.add("invalid");
  }

}
input2.onfocus=function()
{

if(input2.value.length >= 6) {
    length.classList.remove("invalid");
    length.classList.add("valid");
  } else {
    length.classList.remove("valid");
    length.classList.add("invalid");
  }

}