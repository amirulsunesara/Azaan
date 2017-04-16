<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  
 
    <!--=============================================== 
    Template Design By WpFreeware Team.
    Author URI : http://www.wpfreeware.com/
    ====================================================-->

    <!-- Basic Page Needs
    ================================================== -->
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
     <title>Azaan-The Call Within</title>

    <!-- Mobile Specific Metas
    ================================================== -->
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- Favicon -->
    <link rel="shortcut icon" type="image/icon" href="img/wpf-favicon.png"/>

    <!-- CSS
    ================================================== -->       
    <!-- Bootstrap css file-->
    <link href="css/bootstrap1.min.css" rel="stylesheet">
    <!-- Font awesome css file-->
    <link href="css/font-awesome.min.css" rel="stylesheet">
    <!-- Superslide css file-->
    <link rel="stylesheet" href="css/superslides.css">
    <!-- Slick slider css file -->
    <link href="css/slick.css" rel="stylesheet"> 
    <!-- Circle counter cdn css file -->
    <link rel='stylesheet prefetch' href='https://cdn.rawgit.com/pguso/jquery-plugin-circliful/master/css/jquery.circliful.css'>  
    <!-- smooth animate css file -->
    <link rel="stylesheet" href="css/animate.css"> 
    <!-- preloader -->
    <link rel="stylesheet" href="css/queryLoader.css" type="text/css" />
    <!-- gallery slider css -->
    <link type="text/css" media="all" rel="stylesheet" href="css/jquery.tosrus.all.css" />    
    <!-- Default Theme css file -->
    <link id="switcher" href="css/themes/default-theme.css" rel="stylesheet">
    <!-- Main structure css file -->
    <link href="style.css" rel="stylesheet">
   
    <!-- Google fonts -->
    <link href='http://fonts.googleapis.com/css?family=Merriweather' rel='stylesheet' type='text/css'>   
    <link href='http://fonts.googleapis.com/css?family=Varela' rel='stylesheet' type='text/css'>    

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
 
  </head>
  <body >    
<form id="form1" runat="server" >
    <!-- SCROLL TOP BUTTON -->
    <a class="scrollToTop" href="#"></a>
    <!-- END SCROLL TOP BUTTON -->

    <!--=========== BEGIN HEADER SECTION ================-->
      <header id="header">
          <!-- BEGIN MENU -->
          <div class="menu_area">
              <nav class="navbar navbar-default navbar-fixed-top" role="navigation">
                  <div class="container">
                      <div class="navbar-header">
                          <!-- FOR MOBILE VIEW COLLAPSED BUTTON -->
                          <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
                              <span class="sr-only">Toggle navigation</span>
                              <span class="icon-bar"></span>
                              <span class="icon-bar"></span>
                              <span class="icon-bar"></span>
                          </button>
                          <!-- LOGO -->
                          <!-- TEXT BASED LOGO -->
                        
                          <!-- IMG BASED LOGO  -->
                           <a class=""  href="index.aspx"><img height="150px" width="200px" src="img/azaanLOGO.png" alt="logo"></a>  

                      </div>
                     
                      <div id="navbar" class="navbar-collapse collapse" >
                          <ul id="top-menu" class="nav navbar-nav navbar-right main-nav" >
                              <a>&nbsp;</a>
                              <table>
                                  <tr><td><label style="color:white;">Enter Email:<label></td><td><label style="color:white;">Enter Password:</label></td></tr>
                                  <tr><td><asp:TextBox ID="txtEmail" CssClass="form-control-static" runat="server" Width="95%"></asp:TextBox> </td> <td><asp:TextBox ID="txtPassword" Width="95%" CssClass="form-control-static" runat="server" TextMode="Password"></asp:TextBox></td><td><asp:Button ID="btnLogin" runat="server"  CssClass="btn btn-primary" Text="Login" OnClick="btnLogin_Click" /></td></tr>
                                    <tr><td><a href="SignUpp.aspx" style="color:white;">Register For Workshops</a></td><td></td></tr> 
                                  <tr><td >
                                      <asp:Label ID="lblAuth" runat="server" ForeColor="Red"  Font-Bold="True"></asp:Label></td></tr>                            
                              </table>&nbsp&nbsp
                                 
                           

              <ul id="top-menu" class="nav navbar-nav navbar-right main-nav">
              
              </ul>           
        

                 
            
            
                             

                          </ul>

                      </div><!--/.nav-collapse -->
                      
                  </div>
                
              </nav>
             
             
          </div>
          <!-- END MENU -->
      </header>
        <br /><br />
    <!--=========== END HEADER SECTION ================--> 
                  <section id="slider">
      <div class="row">
        <div class="col-lg-12 col-md-12">
          <div class="slider_area">
            <!-- Start super slider -->
            <div id="slides">
              <ul class="slides-container">                          
               
                <!-- Start single slider-->
                    <li>
                  <img src="img/slider/livedeen.jpg" alt="img">
                   <div class="slider_caption">
                    <h2>Best instructors</h2>
                    <p>Highly trainned and professional instructors are ready to serve you</p>
               
                  </div>
                </li>
                <li>
                  <img src="img/slider/livedeen2.jpg" alt="img">
                   <div class="slider_caption slider_right_caption">
                    <h2>Better Education Environment</h2>
                    <p>Towns best venues are chosen </p>
               
                  </div>
                </li>
                <!-- Start single slider-->
              
                   <li>
                
                  <img src="img/slider/a2.PNG" alt="img">
                   <div class="slider_caption">
                    <h2>For Every Age</h2>
                    <p>No age to get knowledge</p>
                   
                  </div>
                  </li>
              </ul>
              <nav class="slides-navigation">
                <a href="#" class="next"></a>
                <a href="#" class="prev"></a>
              </nav>
            </div>
          </div>
        </div>
      </div>
    </section>
    <!--=========== END SLIDER SECTION ================-->

   
    <!--=========== BEGIN WHY US SECTION ================-->
    <section id="whyUs">
      <!-- Start why us top -->
      <div class="row">        
        <div class="col-lg-12 col-sm-12">
          <div class="whyus_top">
            <div class="container">
              <!-- Why us top titile -->
              <div class="row">
                <div class="col-lg-12 col-md-12"> 
                  <div class="title_area">
                    <h2 class="title_two">Why Us</h2>
                    <span></span> 
                  </div>
                </div>
              </div>
              <!-- End Why us top titile -->
              <!-- Start Why us top content  -->
              <div class="row">
                <div class="col-lg-3 col-md-3 col-sm-3">
                  <div class="single_whyus_top wow fadeInUp">
                    <div class="whyus_icon">
                      <span class="fa fa-desktop"></span>
                    </div>
                    <h3>Technology</h3>
                    <p> Through state of the art video conferencing, you’ll be able to interact directly and pose your questions to scholars who speak your language and understand your day-to-day problems. Imagine! You can finally ‘connect’ with and learn Islam from a scholar who understands you and the world you live in.</p>
                  </div>
                </div>
                <div class="col-lg-3 col-md-3 col-sm-3">
                  <div class="single_whyus_top wow fadeInUp">
                    <div class="whyus_icon">
                      <span class="fa fa-users"></span>
                    </div>
                    <h3>Best Tutor</h3>
                    <p>For the first time in Pakistan, Azaan is arranging Islamic lectureshops in English, conducted by internationally renowned Islamic scholars from countries including: Saudi Arabia, UAE, United States and Britain. Our panel of scholars include personalities such as: Dr. Abu Ameenah Bilal Philips, Abdul Raheem Green, Asim Al Hakeem, and many more!</p>
                  </div>
                </div>
                <div class="col-lg-3 col-md-3 col-sm-3">
                  <div class="single_whyus_top wow fadeInUp">
                    <div class="whyus_icon">
                      <span class="fa fa-pencil"></span>
                    </div>
                    <h3>Practical Training</h3>
                    <p> The purpose of each lectureshop is to get you involved, so that you don’t just learn abstract theories, but also learn how to apply Islam in your everyday life. Group participation also makes the sessions more fun and lively for both participants and speakers.</p>
                  </div>
                </div>
                <div class="col-lg-3 col-md-3 col-sm-3">
                  <div class="single_whyus_top wow fadeInUp">
                    <div class="whyus_icon">
                      <span class="fa fa-support"></span>
                    </div>
                    <h3>Support</h3>
                    <p>We speak English! We’ve grown up in an English speaking environment, studied in English-medium schools, and have English speaking friends. So… it’s a big challenge for us to learn about Islam in Urdu!</p>
                  </div>
                </div>
              </div>
              <!-- End Why us top content  -->
            </div>
          </div>
        </div>        
      </div>
      <!-- End why us top -->

      <!-- Start why us bottom -->
      <div class="row">        
        <div class="col-lg-12 col-sm-12">
          <div class="whyus_bottom">            
            <div class="slider_overlay"></div>
            <div class="container">               
              <div class="skills">                
                <!-- START SINGLE SKILL-->
                <div class="col-lg-3 col-md-3 col-sm-3">
                 <div class="single_skill wow fadeInUp">
                   <div id="myStat" data-dimension="150" data-text="35%" data-info="" data-width="10" data-fontsize="25" data-percent="35" data-fgcolor="#999" data-bgcolor="#fff"  data-icon="fa-task"></div>
                    <h4>Repeate Learners</h4>                      
                  </div>
                </div>
                <!-- START SINGLE SKILL-->
                <div class="col-lg-3 col-md-3 col-sm-3">
                  <div class="single_skill wow fadeInUp">
                    <div id="myStathalf2" data-dimension="150" data-text="90%" data-info="" data-width="10" data-fontsize="25" data-percent="90" data-fgcolor="#999" data-bgcolor="#fff"  data-icon="fa-task"></div>
                    <h4>Success Rate</h4>
                  </div>
                </div>
                <!-- START SINGLE SKILL-->
                <div class="col-lg-3 col-md-3 col-sm-3">                 
                  <div class="single_skill wow fadeInUp">
                    <div id="myStat2" data-dimension="150" data-text="100%" data-info="" data-width="10" data-fontsize="25" data-percent="100" data-fgcolor="#999" data-bgcolor="#fff"  data-icon="fa-task"></div>
                    <h4>Student Engagement</h4>
                  </div>
                </div>
                <!-- START SINGLE SKILL-->
                <div class="col-lg-3 col-md-3 col-sm-3">                 
                  <div class="single_skill wow fadeInUp">
                    <div id="myStat3" data-dimension="150" data-text="65%" data-info="" data-width="10" data-fontsize="25" data-percent="65" data-fgcolor="#999" data-bgcolor="#fff"  data-icon="fa-task"></div>
                    <h4>Certified Workshops</h4>
                  </div>
                </div>
              </div>
            </div>            
          </div>
        </div>        
      </div>
      <!-- End why us bottom -->
    </section>
    <!--=========== END WHY US SECTION ================-->
     <!--=========== BEGIN ABOUT US SECTION ================-->
   
    <!--=========== END ABOUT US SECTION ================--> 


    <!--=========== BEGIN OUR COURSES SECTION ================-->
    <section id="ourCourses">
      <div class="container">
       <!-- Our courses titile -->
        <div class="row">
          <div class="col-lg-12 col-md-12"> 
            <div class="title_area">
              <h2 class="title_two">Our Workshops</h2>
              <span></span> 
            </div>
          </div>
        </div>
        <!-- End Our courses titile -->
        <!-- Start Our courses content -->
        <div class="row">
          <div class="col-lg-12 col-md-12 col-sm-12">
            <div class="ourCourse_content">
              <ul class="course_nav">
                <li>
                  <div class="single_course">
                    <div class="singCourse_imgarea">
                      <img src="img/ettiquette.jpg" />
                      <div class="mask">                         
                       
                      </div>
                    </div>
                    <div class="singCourse_content">
                    <h3 class="singCourse_title"><a href="#">Ettiqutes</a></h3>
                  
                    <p>learn the ettiqutes of best man on earth</p>
                    </div>
                    <div class="singCourse_author">
                      <img src="img/inst1.jpg" alt="img">
                      <p>Sheikh Hussain Yee</p>
                    </div>
                  </div>
                </li>
                <li>
                 
                  <div class="single_course">
                    <div class="singCourse_imgarea">
                      <img src="img/return.jpg" />
                      <div class="mask">                         
                      
                      </div>
                    </div>
                    <div class="singCourse_content">
                    <h3 class="singCourse_title"><a href="#">The return</a></h3>
                   
                    <p>A course upon your return journey</p>
                    </div>
                    <div class="singCourse_author">
                   
                      <p>To be announced</p>
                    </div>
                  </div>
                </li>  
                <li>
                  <div class="single_course">
                    <div class="singCourse_imgarea">
                      <img src="img/fun.jpg" />
                      <div class="mask">                         
                      
                      </div>
                    </div>
                    <div class="singCourse_content">
                    <h3 class="singCourse_title"><a href="#">Fun break</a></h3>
                 
                    <p>lets learn how you can enjoy a perfect break</p>
                    </div>
                    <div class="singCourse_author">
                      <img src="img/inst3.jpg" alt="img">
                      <p>Dr. Abu Ameenah Bilal Philips</p>
                    </div>
                  </div>
                </li>
                <li>
                  

        <!-- End Our courses content -->
      </div>
    </section>
    <!--=========== END OUR COURSES SECTION ================-->  

    <!--=========== BEGIN OUR TUTORS SECTION ================-->
    <section id="ourTutors">
      <div class="container">
       <!-- Our courses titile -->
        <div class="row">
          <div class="col-lg-12 col-md-12"> 
            <div class="title_area">
              <h2 class="title_two">Our Tutors</h2>
              <span></span> 
            </div>
          </div>
        </div>
        <!-- End Our courses titile -->

        <!-- Start Our courses content -->
        <div class="row">
          <div class="col-lg-12 col-md-12 col-sm-12">
            <div class="ourTutors_content">
              <!-- Start Tutors nav -->
              <ul class="tutors_nav">
                <li>
                  <div class="single_tutors">
                    <div class="tutors_thumb">
                      <img src="img/inst1.jpg" />                      
                    </div>
                    <div class="singTutors_content">
                      <h3 class="tutors_name">Sheikh Hussain Yee</h3>
                      <span>master</span>
                      <p>Hussain Yee was born in Malaysia to Chinese parents. Soon after coming into Islam, he enrolled into the Madinah University, where he majored in Hadith, and is also privileged to study under the great Hadith scholar, Sheikh Muhammad Nasiruddin Al Albani
</p>
                    </div>
                    <div class="singTutors_social">
                     
                    </div>
                  </div>
                </li>
                <li>
                  <div class="single_tutors">
                    <div class="tutors_thumb">
                      <img src="img/inst2.jpg" />                      
                    </div>
                    <div class="singTutors_content">
                      <h3 class="tutors_name">Sheikh Abu Eesa Niamatullah</h3>
                      <span>Senior Instructor</span>
                      <p>AE was born in London, England to Pakistani parents of the Naser Kheil tribe of Kyber Pakhtunkwa in Pakistan. He has studied Anthropology and Pharmacy at the University of Manchester, and then Arabic, Islamic Law, and the Quran from various scholars around the world including Sheikh Muhammad Salim ‘Abdul Wadud al-Shanqiti (rh), Mufti Taqi al-Usmani, Sheikh Abdullah al-Judai’ and Sheikh Kehlan al-Jubury.</p>
                    </div>
                    <div class="singTutors_social">
                     
                    </div>
                  </div>
                </li>
                <li>
                  <div class="single_tutors">
                    <div class="tutors_thumb">
                      <img src="img/inst3.jpg" />                      
                    </div>
                    <div class="singTutors_content">
                      <h3 class="tutors_name">Dr. Abu Ameenah Bilal Philips</h3>
                      <span>Senior Instructor</span>
                      <p>Abu Ameenah Bilal Philips was born in Jamaica, but grew up in Canada, where he accepted Islam in 1972. He completed a diploma in Arabic and a B.A. from the College of Islamic Disciplines (Usool ad-Deen) at the Islamic University of Madeenah in 1979. At the University of Riyadh, College of Education, he completed a M.A. in Islamic Theology in 1985, and in the department of Islamic Studies at the University of Wales, he completed a Ph.D. in Islamic Theology in 1994.</p>
                    </div>
                    <div class="singTutors_social">
                      
                    </div>
                  </div>
                </li>
                <li>
                  <div class="single_tutors">
                    <div class="tutors_thumb">
                      <img src="img/inst4.jpg" />                      
                    </div>
                    <div class="singTutors_content">
                      <h3 class="tutors_name">Sheikh Abu Abdissalam</h3>
                      <span>Instructor</span>
                      <p>Abu ‘Abdissalam is a graduate from Dar Al-Hadith Al-Khayriyyah in Makkah. He appears regularly on Islam Channel and Huda TV and is currently a lecturer for Al-Kauthar Institute.</p>
                    </div>
                    <div class="singTutors_social">
                     
                    </div>
                  </div>
                </li>
                <li>
                  <div class="single_tutors">
                    <div class="tutors_thumb">
                      <img src="img/inst5.jpg" />                      
                    </div>
                    <div class="singTutors_content">
                      <h3 class="tutors_name">Sheikh Tawfique Chowdhury</h3>
                      <span>Instructor</span>
                      <p>Sheikh Tawfique Chowdhury is Chairman & CEO of Mercy Mission – a global movement dedicated to achieving the vision of Rasoolullah ?</p>
                    </div>
                    <div class="singTutors_social">
                     
                    </div>
                  </div>
                </li>
                <li>
                  <div class="single_tutors">
                    <div class="tutors_thumb">
                      <img src="img/inst6.jpg" />                      
                    </div>
                    <div class="singTutors_content">
                      <h3 class="tutors_name">Abdul Raheem Greem</h3>
                      <span>Technology Teacher</span>
                      <p>Abdurraheem Green has been active in the field of dawah, inviting people to Islam, for the better part of 30 years. Founder and Chairman of iERA, www.fb.com/iERAuk, the Islamic Education & Research Academy</p>
                    </div>
                    <div class="singTutors_social">
                     
                    </div>
                  </div>
                </li>                                             
              </ul>
            </div>
          </div>
        </div>
        <!-- End Our courses content -->
      </div>
    </section>
    <!--=========== END OUR TUTORS SECTION ================-->

    


  
    <!--=========== BEGIN FOOTER SECTION ================-->
    <footer id="footer" style="text-align:center">
      <!-- Start footer top area -->
              <div class="footer_top">
        <div class="container" style="text-align:center">
          <div class="row" style="text-align:center">
            <div class="col-ld-3  col-md-3 col-sm-3" style="text-align:center">
           
              <div class="single_footer_widget"  style="text-align:center">
                <h3 style="text-align:center">About Us</h3>
                  <p style="text-align:center">Azaan aims to connect you to the Deen of Allah, and to His people. Together in this quest for Jannah, we hope to help one another stay firm on the Book of Allah. Our audience is diverse, belonging to different strata of the Pakistani community be it Muslim or Non-Muslim.</p>
              </div>
                   
            </div>
  
                 <div class="col-ld-3  col-md-3 col-sm-3">
              <div class="single_footer_widget">
                <h3 style="visibility:hidden">Others</h3>
                
              </div>
            </div>     
              
            
           
            <div class="col-ld-3  col-md-3 col-sm-3" style="text-align:center">
              <div class="single_footer_widget" style="text-align:center">
                <h3 style="text-align:center">Social Links</h3>
                <ul class="footer_social" style="text-align:right">
                <li style="text-align:center"><a data-toggle="tooltip" data-placement="top" title="Facebook" class="soc_tooltip" href="https://www.facebook.com/"><i class="fa fa-facebook"></i></a></li>
                  <li style="text-align:center"><a data-toggle="tooltip" data-placement="top" title="Twitter" class="soc_tooltip"  href="#"><i class="https://twitter.com"></i></a></li>
              
                  <li style="text-align:center"><a data-toggle="tooltip" data-placement="top" title="Linkedin" class="soc_tooltip"  href="https://www.linkden.com"><i class="fa fa-linkedin"></i></a></li>
                  <li style="text-align:center"><a data-toggle="tooltip" data-placement="top" title="Youtube" class="soc_tooltip"  href="https://youtube.com"><i class="fa fa-youtube"></i></a></li>
                </ul>
              </div>
            </div>
          </div>
        </div>
     

      </div>
      <!-- End footer top area -->

     
      <!-- End footer bottom area -->
    </footer>
    <!--=========== END FOOTER SECTION ================--> 

  

    <!-- Javascript Files
    ================================================== -->

    <!-- initialize jQuery Library -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
    <!-- Preloader js file -->
    <script src="js/queryloader2.min.js" type="text/javascript"></script>
    <!-- For smooth animatin  -->
    <script src="js/wow.min.js"></script>  
    <!-- Bootstrap js -->
    <script src="js/bootstrap1.min.js"></script>
    <!-- slick slider -->
    <script src="js/slick.min.js"></script>
    <!-- superslides slider -->
    <script src="js/jquery.easing.1.3.js"></script>
    <script src="js/jquery.animate-enhanced.min.js"></script>
    <script src="js/jquery.superslides.min.js" type="text/javascript" charset="utf-8"></script>   
    <!-- for circle counter -->
    <script src='https://cdn.rawgit.com/pguso/jquery-plugin-circliful/master/js/jquery.circliful.min.js'></script>
    <!-- Gallery slider -->
    <script type="text/javascript" language="javascript" src="js/jquery.tosrus.min.all.js"></script>   
   
    <!-- Custom js-->
    <script src="js/custom.js"></script>
    <!--=============================================== 
    Template Design By WpFreeware Team.
    Author URI : http://www.wpfreeware.com/
    ====================================================-->

      </form>
  </body>
</html>
