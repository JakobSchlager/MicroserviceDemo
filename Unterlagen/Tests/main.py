import pymysql

db = pymysql.connect(host='localhost', user='ticketverwaltung', passwd='ticketverwaltung', db='schema_test')
cursor = db.cursor()

#works perfectly fine for table "ticket"
cursor.execute("SELECT * FROM `ticket`")
for i in cursor:
    print(i)

#no execution rights for "film"
cursor.execute("INSERT INTO film (id, Title) VALUES (0, 'test')")
for i in cursor:
    print(i)

db.close()

