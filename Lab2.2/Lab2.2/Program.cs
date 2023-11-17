using Lab2._2;

try
{
    //Implement start position, width and height, symbol, message input

    //Create Box class instance

    //Use  Box.Draw() method

    Box box = new Box();
    box.Draw("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas a tortor eleifend, accumsan est a, imperdiet tellus. Maecenas lobortis nisl diam, sit amet commodo lectus congue eget. Integer molestie maximus luctus. Cras sit amet volutpat augue, a tristique metus. Vivamus posuere neque id est scelerisque varius. Etiam sodales, nisl in interdum pretium, lacus nunc condimentum risus, in semper tortor risus non ipsum. Proin faucibus massa eu massa pretium ullamcorper. Phasellus quis dui venenatis, malesuada justo quis, tincidunt sem. In et nulla quis arcu ultrices finibus nec nec purus. Nunc porttitor tristique sem, a volutpat felis vehicula at.",
             x: 4,
             y: 4,
             width: 10,
             height: 10,
             symbol: '(');

    Console.WriteLine("Press any key...");
    Console.ReadLine(); 
    //Console.SetCursorPosition(0, 0);
}
catch (Exception)
{
    Console.WriteLine("Wrong input or unexpected error!");
}
