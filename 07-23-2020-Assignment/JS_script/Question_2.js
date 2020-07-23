'use strict'
//Health's Team scores
let p1=89      
let p2=120
let p3=103
let p_average1=(p1+p2+p3)/3 //average score of Health's Team

//Zane Team Scores
let p4 =116
let p5=94
let p6=123
let p_average2=(p4+p5+p6)/3 //average score of Zane's Team


if(p_average1>p_average2)
{
    console.log('------------------------Game-1 Result---------------------------')
    console.log(`Health's Team wins and average score of his team is ${p_average1}`)
}
else if(p_average1===p_average2)
{
    console.log('------------------------Game-1 Result---------------------------')
    console.log(`There is a Draw and average score of both team is ${p_average2}`)
}
else
{
    console.log('------------------------Game-1 Result---------------------------')
    console.log(`Zane's Team wins and average score of his team is ${p_average2}`)
}

p1=p1+21  // increses Zane's Team score to level the game.
p_average1=(p1+p2+p3)/3

if(p_average1>p_average2)
{
    console.log('------------------------Game-2 Result---------------------------')
    console.log(`Health's Team wins and average score of his team is ${p_average1}`)
}
else if(p_average1===p_average2)
{
    console.log('------------------------Game-2 Result---------------------------')
    console.log(`There is a Draw and average score of both team is ${p_average2}`)
}
else
{
    console.log('------------------------Game-2 Result---------------------------')
    console.log(`Zane's Team wins and average score of his team is ${p_average2}`)
}

p1=p1+21
p_average1=(p1+p2+p3)/3

if(p_average1>p_average2)
{
    console.log('------------------------Game-3 Result---------------------------')
    console.log(`Health's Team wins and average score of his team is ${p_average1}`)
}
else if(p_average1===p_average2)
{
    console.log('------------------------Game-3 Result---------------------------')
    console.log(`There is a Draw and average score of both team is ${p_average2}`)
}
else
{
    console.log('------------------------Game-3 Result---------------------------')
    console.log(`Zane's Team wins and average score of his team is ${p_average2}`)
}

//In above code instead of writing two or three time same code we can do it with the help of for lopp. 


