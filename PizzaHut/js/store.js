
function store() {
    this.pizzas = [
        new pizza( 1, "Americana", "Eat one every day to keep the doctor away!", 12),
        new pizza( 2, "Barbeque", "Guacamole anyone?", 16),
        new pizza( 3, "Carbonara", "These are rich in Potassium and easy to peel.", 4),
        new pizza( 4, "Margo", "Delicious and refreshing.", 3),
        new pizza( 5, "PepTomato", "OK, not that nutritious, but sooo good!", 10),
        new pizza( 6, "Mushrooms", "Pink or red, always healthy and delicious.", 11),
        new pizza( 7, "Tehas", "Wine is great, but grapes are even better.", 8),
        new pizza( 8, "Havai", "Exotic, fragrant, tasty!", 8),
        new pizza( 9, "Tony", "These come from New Zealand.", 14),
        new pizza( 10, "Vegatable", "Unusual and highly addictive!", 18),
        new pizza( 11, "Country", "Messy to eat, but well worth it.", 8),
        new pizza( 12, "Americana", "Vitamin C anyone? Go ahead, make some juice.", 9),
        new pizza( 13, "Spicy", "Super-popular for breakfast.", 5),
        new pizza( 14, "5Cheeses", "Add some cream and enjoy.", 19),
        new pizza( 15, "Pear", "Delicious fresh, or cooked in red wine, or distilled.", 8),
        new pizza( 16, "Pomegranate", "Delicious, healthy, beautiful, and sophisticated!", 19),
        new pizza( 17, "Pineapple", "Enjoy it (but don't forget to peel first).", 4),
        new pizza( 18, "Persimmon", "Believe it or not, they are berries!", 6),
        new pizza( 19, "Strawberry", "Beautiful, healthy, and delicious.", 7),
        new pizza( 20, "Tangerine", "Easier to peel than oranges!", 8),
        new pizza( 21, "Watermelon", "Nothing comes close on those hot summer days.", 4)
    ];
    this.filteredPizzas = [];
    this.currentPage = 0;
    this.pageSize = 6;
    this.maxSize = 5;
    //this.filter(this.currentPage)
}
store.prototype.getPizza = function (id) {
    for (var i = 0; i < this.pizzas.length; i++) {
        if (this.pizzas[i].id == id)
            return this.pizzas[i];
    }
    return null;
}

store.prototype.numberOfPages = function () {
    return Math.ceil(this.pizzas.length / this.pageSize);
};

