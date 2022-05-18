const urlBase = "https://localhost:44302"

const metodoGet = () => {
    fetch(`${urlBase}/api/person/all`)
        .then( res => res.json())
        .then( res => console.log(res))
}

const metodoGetById = (id) => {
    fetch(`${urlBase}/api/person/${id}`)
        .then( res => res.json())
        .then( res => console.log(res))
}

const metodoPost = () => {
    const person = {
        id:19,
        name:"German",
        age:27,
        email: "german@gmail.com",
        createdDate: "2022-05-12"
    }
    fetch(`${urlBase}/api/person/savePerson`, {
        method: "POST",
        body: JSON.stringify(person),
        headers: {
            "Content-Type": "application/json"
        }
    })
        .then( res => res.json())
        .then( res => console.log(res))
        
}

const metodoPut = () => {
    const person = {
        id:1,
        name:"German",
        age:27,
        email: "german@gmail.com",
        createdDate: "2022-05-12"
    }
    fetch(`${urlBase}/api/person`, {
        method: "PUT",
        body: JSON.stringify(person),
        headers: {
            "Content-Type": "application/json"
        }
    })
        .then( res => res.json())
        .then( res => console.log(res))
        
}

const metodoDelete = (id) => {

    fetch(`${urlBase}/api/person`, {
        method: "DELETE",
        body: JSON.stringify(id),
        headers: {
            "Content-Type": "application/json"
        }
    })
        .then( res => res.json())
        .then( res => console.log(res))
        
}
const metodoDeleteById = (id) => {

    fetch(`${urlBase}/api/person/${id}`, {
        method: "DELETE",
    })
        .then( res => res.json())
        .then( res => console.log(res))
        
}

metodoGet()
metodoGetById(3)
metodoPost()
metodoPut()
metodoDelete(4)
metodoDeleteById(7)