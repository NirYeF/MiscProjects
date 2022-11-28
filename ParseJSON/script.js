var jsonObj =[
    {
        "id": "1",
        "name": "google",
        "url": "www.google.com",
        "subData": [
            {
                "id": "2",
                "name": "walla",
                "url": "www.walla.co.il"
            },
            {
                "id": "3",
                "name": "ynet",
                "url": "www.ynet.co.il",
                "subData": [
                    {
                        "id": "4",
                        "name": "mako",
                        "url": "www.mako.co.il"
                    },
                    {
                        "id": "5",
                        "name": "google",
                        "url": "www.google.com"
                    },
                    {
                        "id": "6",
                        "name": "walla",
                        "url": "www.walla.co.il"
                    }
                ]
            },
            {
                "id": "7",
                "name": "google",
                "url": "www.google.com"
            }
        ]
    },
    {
        "id": "8",
        "name": "ynet",
        "url": "www.ynet.co.il",
        "subData": [
            {
                "id": "9",
                "name": "walla",
                "url": "www.walla.co.il"
            },
            {
                "id": "10",
                "name": "google",
                "url": "www.google.com",
                "subData": [
                    {
                        "id": "11",
                        "name": "ynet",
                        "url": "www.ynet.co.il",
                        "subData": [
                            {
                                "id": "12",
                                "name": "walla",
                                "url": "www.walla.co.il"
                            },
                            {
                                "id": "13",
                                "name": "google",
                                "url": "www.google.com"
                            },
                            {
                                "id": "14",
                                "name": "mako",
                                "url": "www.mako.co.il"
                            }
                        ]
                    },
                    {
                        "id": "15",
                        "name": "google",
                        "url": "www.google.com"
                    },
                    {
                        "id": "16",
                        "name": "mako",
                        "url": "www.mako.co.il"
                    }
                ]
            },
            {
                "id": "17",
                "name": "walla",
                "url": "www.walla.co.il",
                "subData": [
                    {
                        "id": "18",
                        "name": "ynet",
                        "url": "www.ynet.co.il"
                    },
                    {
                        "id": "19",
                        "name": "google",
                        "url": "www.google.com"
                    },
                    {
                        "id": "20",
                        "name": "walla",
                        "url": "www.walla.co.il"
                    }
                ]
            },
            {
                "id": "21",
                "name": "mako",
                "url": "www.mako.co.il"
            }
        ]
    }
]

var listEl =document.getElementById('element');
makeList(jsonObj,listEl);

function makeList( jsonObject, listElement){
    for(var i in jsonObject){//iterate through the array or object
        //insert the next child into the list as a <li>
        var newLI = document.createElement('li');
        newLI.style.borderRadius='5px';
        newLI.style.listStyle='none';
        if(i === "name")
        {
            var text = document.createTextNode("Site Name"+":"+" "+jsonObject[i]);
            newLI.appendChild(text);
            listElement.appendChild(newLI);
            continue;
        }
        if(i === "url")
        {
            var newAnchor = document.createElement("a");
            newAnchor.textContent = "Site Url"+":"+" "+jsonObject[i];
            var http="https://"+jsonObject[i];
            newAnchor.setAttribute('href',http);
            newLI.appendChild(newAnchor);
            listElement.appendChild(newLI);
            continue;
        }
        if  (jsonObject[i] instanceof Array || jsonObject[i] instanceof Object){
            newLI.className="arrayOrObject";
        }
        else
            newLI.innerHTML=i+': '+jsonObject[i];
        listElement.appendChild(newLI);
        var count=0;
        if  (jsonObject[i] instanceof Array || jsonObject[i] instanceof Object){
            var newUL = document.createElement('ul');
            newUL.style.float='left';
            newUL.style.backgroundColor=Math.floor(Math.random()*16777215).toString(16);
            listElement.appendChild(newUL);
            makeList(jsonObject[i],newUL);
        }
    }
}
