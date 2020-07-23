'use strict'

let jeffMass=60
let toddMass=65


let todd_Height=8
let jeff_Height=9

let jeffBMI=jeffMass/(jeff_Height*jeff_Height)
let toddBMI=toddMass/(todd_Height*todd_Height)

var res=true
if(jeffBMI>toddBMI)
{
    console.log('Is jeff_BMI greater than todd_BMI : ' + res)
}
else
{
    console.log('Is todd_BMI greater than jeff_BMI : ' + res)
}