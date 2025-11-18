/* GLOBAL STYLES */
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    font-family: Arial, sans-serif;
}

body {
    background-color: #eaeded; /* Light gray background */
}

a {
    text-decoration: none;
    color: #007185; /* Amazon blue link color */
}

/* 1. HEADER STYLING */
#header {
    background-color: #131921; /* Dark blue/black */
    color: #fff;
    position: sticky;
    top: 0;
    z-index: 100;
}

.header-container {
    display: flex;
    align-items: center;
    padding: 10px 20px;
    height: 60px;
}

/* Logo */
.header-logo {
    display: flex;
    align-items: flex-end;
    margin-right: 15px;
    padding: 0 5px;
    height: 100%;
}
.header-logo img {
    width: 97px; /* Standard Amazon logo width */
    height: 30px;
}
.logo-country {
    font-size: 14px;
    margin-left: -2px; /* Pull the .in closer to the logo */
    font-weight: bold;
}

/* Search Bar */
.header-search {
    flex-grow: 1; /* Takes up most of the space */
    display: flex;
    max-width: 800px;
    margin: 0 15px;
}
.header-search input {
    flex-grow: 1;
    height: 40px;
    padding: 10px;
    border: none;
    border-radius: 4px 0 0 4px;
}
.header-search button {
    width: 45px;
    height: 40px;
    background-color: #febd69; /* Orange button */
    border: none;
    border-radius: 0 4px 4px 0;
    cursor: pointer;
    color: #131921;
    font-size: 17px;
}

/* Navigation Links */
.header-nav {
    display: flex;
    align-items: center;
}
.nav-item {
    padding: 5px 9px;
    margin-left: 10px;
    cursor: pointer;
}
.nav-item .line-one {
    font-size: 12px;
}
.nav-item .line-two {
    font-size: 14px;
    font-weight: bold;
}
.nav-cart {
    display: flex;
    align-items: flex-end;
}
.nav-cart i {
    font-size: 30px;
    margin-right: 5px;
}
.cart-count {
    position: absolute;
    top: 10px;
    font-size: 15px;
    font-weight: bold;
    color: #febd69;
}

/* 2. SECONDARY NAV STYLING */
#secondary-nav {
    background-color: #232f3e; /* Darker blue */
    height: 39px;
    display: flex;
    align-items: center;
    padding: 0 20px;
}

#secondary-nav ul {
    list-style: none;
    display: flex;
}

#secondary-nav li a {
    color: #fff;
    padding: 8px 9px;
    display: block;
    font-size: 14px;
    border: 1px solid transparent; /* For hover effect */
}
#secondary-nav li a:hover {
    border-color: #fff;
}
#secondary-nav li:first-child a i {
    margin-right: 5px;
}

/* 3. MAIN CONTENT STYLING */
#main-content {
    max-width: 1500px;
    margin: 0 auto;
    padding-bottom: 30px;
}

/* Hero Section */
.hero-section {
    position: relative;
    top: -150px; /* Adjust this value to overlap the content with the nav bar */
}
.hero-img {
    width: 100%;
    mask-image: linear-gradient(to bottom, rgba(0,0,0,1), rgba(0,0,0,0)); /* Fade to transparency at the bottom */
}

/* Product Grid */
.product-grid {
    display: grid;
    grid-template-columns: repeat(4, 1fr); /* 4 columns of equal width */
    gap: 20px;
    padding: 0 20px;
    margin-top: -300px; /* Pull the grid up over the faded part of the hero image */
}

.product-card {
    background-color: #fff;
    padding: 20px;
    height: 420px;
    z-index: 10;
    box-shadow: 0 2px 5px rgba(0,0,0,0.1);
}

.product-card h3 {
    font-size: 21px;
    margin-bottom: 10px;
}

.product-card img {
    width: 100%;
    max-height: 280px;
    object-fit: contain;
    margin-bottom: 15px;
}

.sign-in-prompt button {
    width: 100%;
    padding: 10px;
    background-color: #f7dfa5;
    border: 1px solid #f0c14b;
    border-radius: 3px;
    cursor: pointer;
    margin-bottom: 10px;
}

/* 4. FOOTER STYLING */
#footer {
    background-color: #232f3e;
    color: #fff;
}

.back-to-top {
    display: block;
    text-align: center;
    background-color: #37475a;
    color: #fff;
    padding: 15px;
    font-size: 13px;
}

.footer-links {
    background-color: #232f3e;
    display: flex;
    justify-content: space-around;
    padding: 40px 0;
    border-bottom: 1px solid #3a4553;
}
.footer-col h4 {
    margin-bottom: 10px;
    font-size: 16px;
    font-weight: bold;
}
.footer-col ul {
    list-style: none;
}
.footer-col ul li a {
    color: #ddd;
    font-size: 14px;
    line-height: 1.5;
}

.footer-bottom {
    background-color: #131a22;
    text-align: center;
    padding: 20px;
}
.footer-bottom p {
    font-size: 12px;
    color: #ccc;
}
