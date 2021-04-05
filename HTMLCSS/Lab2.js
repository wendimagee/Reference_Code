
function Lab2(){
    let goOn= true;
    while(goOn=true)
    {
        let width =prompt("Please input a width for your room")
        let height=prompt("please input a height for your room")
        let length=prompt("please input a length for your room")
        console.log(width*height*length)
        
        let area = length * width;
        console.log('Area is ${area}')
        goOn = ContinueRunning();
    }
    
    function ContinueRunning(){
        prompt("Would you like to Continue? y/n?");
        if("y"===Response.toLowerCase().trim())
        {
            return true;
        }
        else if("n"===Response.toLowerCase().trim()){
            return false;
        }
        else{
            alert("Hey I didn't understand that. Let's try again.");
            return ContinueRunning();
        }
}
//prompt is JS console.Readline
//a pop-up window is coming! I'm so excited!
//put a string in as parameter to display on pop up window
}