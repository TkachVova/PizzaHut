// order class
function order() {
    this.client = new customer("-1", "", "");
    this.deliveryAddress = "";
    this.items = [];
}


//set items from cart to order after pressing button make order
order.prototype.SetItems = function (items) {
    this.items = items;
}


//Clear order after posting order
order.prototype.ClearOrder = function () {
    this.userName = "";
    this.userAddress = "";
    this.userPhone = "";
    this.items = [];
}

order.prototype.submit = function () {
}

//funktion for posting order
order.prototype.Post = function () {
//    var Order = {
//    userName:"" ,
//    userAddress:"" ,
//    userPhone:"" ,
//    items : []
//};
//Order.userName = this.userName;
//Order.userAddress = this.userAddress;
//Order.userPhone = this.userPhone;
//Order.items = this.items;
alert(JSON.stringify(this));
$.ajax({
    type: "POST",
    data: JSON.stringify(this),
    url: "api/api/pizza",
    contentType: "application/json"
});
this.ClearOrder();
//alert(JSON.stringify(Order));
};
 

function customer(id, name, phone) {
    this.id = id;
    this.name = name;
    this.phone = phone;
}
