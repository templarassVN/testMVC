const form = document.getElementById("test")
const checkBoxes = form.querySelectorAll("input[type=\"checkbox\"]")


console.log(checkBoxes)
form.onsubmit = function (e) {
    console.log(e);
    let f = [];
    checkBoxes.forEach(o => {
        if (o.checked)
            f.push(o.value);
    })
    const params = new URLSearchParams({
        filter: f.join(" ")
    })
    this.action = `?${params}`;
    window.location.href = `?${params}`;
    e.preventDefault();
}
