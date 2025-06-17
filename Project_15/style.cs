@import url('https://fonts.googleapis.com/css2?family=Poppins:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900&family=Roboto:ital,wght@0,100..900;1,100..900&family=Rubik:ital,wght@0,300..900;1,300..900&display=swap');
*{
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

html,body{
    width: 100%;
    height: 100vh;
    background-color: #000;
    color: #fff;
    font-family: "Rubik", sans-serif;
}

.navbar{
    width: 100%;
    height: 100px;
    display: flex;
    justify-content: space-between;
    align-items: center;
    padding: 0 60px ;
}

.navbar .nav-left i{
    margin-right: 12px;
    font-size: 20px;
}

.navbar .nav-left, .nav-right{
    font-size: 20px;
}

.navbar .nav-mid{
    display: flex;
    align-items: center;
    gap: 20px;
}
.navbar .nav-mid a{
    color: #fff;
    text-decoration: none;
}


.navbar .nav-mid>img{
    width: 200px;
    padding: 0px 20px;
}

.navbar .nav-mid .line{
    width: 70px;
    height: 2px;
    background-color: red;
}

/*  content  */

.content{
    display: flex;
    height: calc(100vh - 100px);
    width: 100%;
    /* background-color: red; */
}

.content .content-left{
    width: 35%;
    height: 100%; 
    padding: 180px 60px;
}

.content .content-left h1{
    font-size: 67px;
    line-height: 70px;
    margin-bottom: 50px;
}

.content .content-left h1 span{
    font-weight: 300;
    color: red;
}

.content .content-left p{
    font-size: 16px;
    line-height: 18px;
    color: #ffffff94;
    margin-bottom: 50px;
    padding-right: 50px;
}

.content .content-left button{
    padding: 15px 40px;
    background-color: red;
    border-radius: 50px;
    border: none;
    color: #fff;
    font-size: 20px;
    font-weight: 600;
}

.content .content-left i{
    margin-right: 15px;
}

.content .content-mid{
    width: 30%;
    
    height: 100%;
   position: relative;
}

.content-mid .center-bg{
    background-image: url(https://images.jdmagicbox.com/quickquotes/images_main/promotional-led-neon-letter-sign-board-red-2227037322-qtvzv5ho.jpg);
    height: 85%;
    margin-top: 90px;
    background-position: center center;
    background-size: 400% 200% ;
    border-top-left-radius: 1000px;
    border-top-right-radius: 1000px;
    filter: blur(6px);
}


.content-mid>img{
    width: 500px;
    position: absolute;
    top: 0;
}

.content .content-right{
    width: 35%;
    height: calc(100% - 300px);
    position: relative;
    margin-top: 300px;
    margin-right: 40px;
}

.content-right .list {
    margin-left: 60px;
    padding: 20px 0;
    border-bottom: 2px solid #b1b1b1;
    color: #8b8b8bd1;
    display: flex;
    width: 400px;
    justify-content: space-between;
    /* position: absolute; */
    font-size: 35px;
}

.content-right .last{
    color: #fff;
    font-size: 20px;
    display: block;
    border: none;
    font-size: 35px;
    font-weight: 200;
}

.content-right .last p{
    color: rgba(118, 117, 117, 0.761);
    font-size: 15px;
    margin-top: 10px;
}
