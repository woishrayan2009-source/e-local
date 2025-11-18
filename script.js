document.addEventListener('DOMContentLoaded', () => {
    const cartCountElement = document.querySelector('.cart-count');
    const navCartElement = document.querySelector('.nav-cart');

    // Simulate an initial cart item count
    let cartItemCount = 0;

    // A simple function to update the cart count visually
    function updateCartCount() {
        cartCountElement.textContent = cartItemCount;
    }

    // Example of how you would add an item (e.g., when a user clicks 'Add to Cart')
    navCartElement.addEventListener('click', () => {
        // In a real application, this would be triggered by an 'Add to Cart' button
        // and you'd pass the actual product data.
        cartItemCount++;
        updateCartCount();
        console.log(`Item added. Total items: ${cartItemCount}`);
        alert('Item added to cart!');
    });

    // Initialize the count on page load
    updateCartCount();
});

// A function to showcase the hover/active state of the search bar
const searchInput = document.querySelector('.header-search input');
const searchButton = document.querySelector('.header-search button');
const searchContainer = document.querySelector('.header-search');

searchInput.addEventListener('focus', () => {
    searchContainer.style.outline = '3px solid #f90'; // Amazon's orange focus
});

searchInput.addEventListener('blur', () => {
    searchContainer.style.outline = 'none';
});
