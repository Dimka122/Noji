document.addEventListener('DOMContentLoaded', (e) => {

    document.addEventListener('DOMContentLoaded', () => {
        let urlApi = 'https://localhost:7077/Knives';
        fetch(urlApi)
            .then((res) => {
                return res.json();
            })
            .then((data) => {
                let container = document.getElementById('container');
                for (const iterator of data) {
                    let cart = document.createElement('div');
                    cart.setAttribute('class', 'cart');
                    cart.setAttribute('id', `${iterator['Name']}_${iterator['Steel']}`);
                    cart.innerText = `${iterator['Name']}-${iterator['Steel']}: ${iterator['Price']} / ${iterator['sale']}`;
                    container.append(cart);
                }
                // console.log(data);
            })
            .catch((err) => {
                console.error("BAD API!");
            });
    });
});