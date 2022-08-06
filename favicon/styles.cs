                                            @import url('https://fonts.googleapis.com/css2?family=Lato:wght@400;700&display=swap');
                                        /* global styles */
                                        
                                        *,
                                        *::before,
                                        *::after {
                                            margin: 0;
                                            padding: 0;
                                            box-sizing: border-box;
                                        }
                                        
                                        html {
                                            font-family: "Lato", sans-serif;
                                            font-weight: 400;
                                            font-size: 20px;
                                            scroll-behaviour: smooth;
                                        }
                                        
                                        h1 {
                                            font-family: "Lato", sans-serif;
                                            font-weight: 700;
                                        }
                                        /* body styling */
                                        
                                        .main {
                                            height: 100vh;
                                        }
                                        
                                        .second-line {
                                            display: flex;
                                            flex: 1;
                                            justify-content: flex-end;
                                            margin: 63px 50px 113px 119px;
                                            padding: 50px 20px 100px 20px;
                                        }
                                        
                                        .zuri {
                                            font-weight: 700;
                                            font-size: 40px;
                                        }
                                        
                                        .zuricon-logo {
                                            width: 30%;
                                            height: 20%;
                                            padding: 0px;
                                            margin: 10px;
                                        }
                                        
                                        .first-line {
                                            display: flex;
                                            flex: 1;
                                            justify-content: space-between;
                                            align-items: center;
                                            margin-bottom: ;
                                            margin: 50px 50px 0px 0px;
                                            padding: 1.4em;
                                        }
                                        
                                        .nav {
                                            overflow: hidden;
                                            background-color: white;
                                            position: relative;
                                        }
                                        
                                        .nav #my-links {
                                            display: none;
                                        }
                                        
                                        .nav a {
                                            color: black;
                                            padding: 14px 16px;
                                            text-decoration: none;
                                            font-size: 17px;
                                            display: block;
                                        }
                                        
                                        .nav a svg {
                                            position: absolute;
                                            right: 0;
                                            top: 0;
                                            transition: 0.1s;
                                        }
                                        
                                        .nav svg:hover {
                                            cursor: pointer;
                                        }
                                        
                                        hr {
                                            margin: 0px;
                                        }
                                        
                                        .a {
                                            text-decoration: none;
                                            color: black;
                                            font-size: 20px;
                                        }
                                        
                                        .box-left {
                                            padding: 0px 20px;
                                            margin-left: 20px;
                                        }
                                        
                                        .box-right: {
                                            padding: 50px;
                                        }
                                        
                                        .main-img {
                                            height: 350px;
                                            width: 400px;
                                        }
                                        
                                        .p,
                                        .reset,
                                        .small {
                                            text-align: center;
                                        }
                                        
                                        .small {
                                            font-size: 15px;
                                            text-align: center;
                                        }
                                        
                                        .reset {
                                            color: #251181;
                                            ;
                                            margin-top: -10px;
                                        }
                                        
                                        . input {
                                            width: 95%;
                                            padding: 10px;
                                            margin: 5px;
                                            background: transparent;
                                            border: 1px solid #CCC6C6;
                                            color: #CCC6C6;
                                            border-radius: 10px;
                                            font-size: 20px;
                                        }
                                        
                                        placeholder {
                                            font-size: 20px;
                                            font-weight: 400px;
                                        }
                                        
                                        button {
                                            width: 100%;
                                            text-align: center;
                                            padding: 10px;
                                            margin: 5px;
                                            background: transparent;
                                            color: black;
                                            font-weight: 400;
                                            border-radius: 10px;
                                            border: 1px solid grey;
                                        }
                                        
                                        .enter {
                                            text-align: left;
                                            width: 400px;
                                        }
                                        
                                        @media only screen and (min-width: 1195px) and (max-width:1512px) {
                                            .nav,
                                            .p,
                                            .icon,
                                            hr,
                                            .forgot {
                                                display: none;
                                            }
                                        }
                                        
                                        @media only screen and (min-width: 429px) and (max-width: 834px) {
                                            .main-img {
                                                width: ;
                                                height: ;
                                            }
                                            .enter {
                                                color: yellow;
                                            }
                                            .icon,
                                            .navlink,
                                            .forgot {
                                                display: none;
                                            }
                                            input {}
                                            button {}
                                            .box-left {}
                                            .box-right {}
                                        }
                                        
                                        @media screen and (max-width: 428px) {
                                            .main-img {
                                                display: none;
                                            }
                                            .second-line {
                                                display: flex;
                                                flex-direction: column;
                                                align-items: center;
                                                padding: 10px;
                                                margin: 100px;
                                            }
                                            body {
                                                max-width: 428px;
                                            }
                                            .main {
                                                width: 100%;
                                            }
                                            .forgot {
                                                color: blue;
                                                text-align: center;
                                            }
                                            .reset {
                                                display: none;
                                            }
                                            input {
                                                width: 90%;
                                                padding: 10px 5px;
                                                margin: 15px;
                                                background: transparent;
                                                border: 1px solid grey;
                                                color: grey;
                                                border-radius: 10px;
                                                font-size: 20px;
                                            }
                                            .small {
                                                align-items: center;
                                                font-size: 20px;
                                                width: 95%;
                                                margin: 0px 0px 0px 10px;
                                            }
                                            .inputs {
                                                align-items: center;
                                                font-size: 20px;
                                                width: 95%;
                                            }
                                            label {
                                                margin: 0px 0px 0px 10px;
                                            }
                                            placeholder {
                                                font-size: 20px;
                                                font-weight: 400px;
                                            }
                                            button {
                                                width: 93%;
                                                text-align: center;
                                                padding: 10px 5px;
                                                margin: 15px;
                                                background: transparent;
                                                color: black;
                                                font-weight: 400;
                                                border-radius: 10px;
                                                border: 1px solid grey;
                                            }
                                            .enter {
                                                width: 365px;
                                                color: blue;
                                                font-size: 20px;
                                            }
                                            .first-line {
                                                display: flex;
                                                flex: 1;
                                                justify-content: space-between;
                                                align-items: center;
                                                margin-bottom: ;
                                                margin: 50px 10px 0px 0px;
                                                padding: 10px;
                                            }
                                            .zuricon-logo {
                                                width: 20%;
                                                height: 30px;
                                            }
                                            .zuza {
                                                margin: 0px;
                                            }
                                            .navlinks {
                                                margin: 5px 0px;
                                                position: relative;
                                            }
                                            .input {
                                                bacground
                                            }

                                            <div class="navlink ">
                    <a href="# " class="active "></a>
                    <div id="my-links ">
                        <a href="# ">Home</a>
                        <a href="# ">Contact</a>
                        <a href="# ">About</a>
                    </div>
                    <a href="javascript:void(0); " class="icon " onclick="myFunction() ">
                        <svg viewBox="0 0 100 80 " width="40 " height="40 "> <rect width="100 " height="20 "></rect> <rect y="30 " width="100 " height="20 "></rect> <rect y="60 " width="100 " height="20 "></rect> </svg>
                    </a>
                </div>

                