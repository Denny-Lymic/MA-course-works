using Lab_4._1;
// 9) declare object of OnlineShop 

OnlineShop adidas = new OnlineShop();

// 10) declare several objects of Customer

Customer andrew = new Customer("Andrew");
Customer matwey = new Customer("Matwey");
Customer petya = new Customer("Petya");

// 11) subscribe method GotNewGoods() of every Customer instance 
// to event NewGoodsInfo of object of OnlineShop

adidas.NewGoodsEvent += andrew.GotNewGoods;
adidas.NewGoodsEvent += matwey.GotNewGoods;
adidas.NewGoodsEvent += petya.GotNewGoods;

// 12) invoke method NewGoods() of object of OnlineShop
// discuss results

adidas.NewGoods("T-shirt \"Mambai\"");

adidas.NewGoodsEvent -= matwey.GotNewGoods;

adidas.NewGoods("Shoes \"Edge Runners\"");
