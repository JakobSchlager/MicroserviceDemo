import pymysql

users = [ 
    "ticketservice", 
    "movieservice", 
    "roomservice", 
]

tables = [
    "ticket", 
    "movie", 
    "presentation", 
    "room", 
    "seat", 
]

for service in users:
    db = pymysql.connect(host='localhost', user=service, passwd=service, db='microservicedemo')
    cursor = db.cursor()

    #works perfectly fine for table "ticket"
    for table in tables: 
        try: 
            cursor.execute("SELECT * FROM `"+table+"`")
            for i in cursor:
                print(i)
        except: 
            print(service + " has no right for "+table+"")

    #cursor.execute("INSERT INTO film (id, Title) VALUES (0, 'test')")
    #for i in cursor:
    #    print(i)

    db.close()

