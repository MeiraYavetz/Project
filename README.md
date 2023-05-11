# HMOProject
DB בSQL
ובו 2 טבלאות, טבלת חבר קופה-Member וטבלת חיסון Vaccine .
בכל חיסון יש ID של חבר קופה וכך הוא משתייך אליו.
צד השרת בשפת C#
מורכב מארכיטקטורת 3 השכבות:
•	שכבת ה Repositories-שהיא מחוברת לCONTEXT שמחובר לDB.
•	שכבת ה Services-בה כתובות הפונקציות/אלגוריתם לפי צורך הפרויקט.
•	שכבת ה WebAPI-בה יש Controllers שבהם פעולות שמקבלות או מדפיסות נתונים ועל ידיהם ניגשים לקוד האלגוריתם מצד הלקוח.
בכל שכבה הזרקת תלות של הקודמת לה וכך הנתונים עוברים בשכבות בין הDB לבין צד הלקוח שנכתב בשפת REACT
צד לקוח:
הטופס הראשי:
   ![alt text](./pictures/צילום מסך 2023-05-08 202940.png)
   שבו ישנם 2 כפתורים:
                                                                                                                                         Add Member-להוספת חבר קופה חדש
 ![alt text](./pictures/צילום מסך 2023-05-11 003404.png)
  ![alt text](./pictures/צילום מסך 2023-05-11 003430.png)
                                                                                                                     Retrieve Member-שולף את הנתונים הנדרשים בפונקציות הבאות:
 ![alt text](./pictures/צילום מסך 2023-05-11 003522.png)    
                                                         1.how many sicks every day in month-פונקציה בה הייתי צריכה לקבל מהמשתמש חודש ושנה ולהחזיר כמה חולים פעילים בכל יום בחודש הזה.
  ![alt text](./pictures/צילום מסך 2023-05-11 004123.png)  
 על פי הנתונים שקיימים במסד הנתונים הקיים לדוג'-הכנסתי את חודש מאי בשנה 2023
התוצאה לא חוזרת באופן גלוי למשתמש אלא בconsole(לחיצה על 12 F) :
 ![alt text](./pictures/צילום מסך 2023-05-11 004307.png) 
                                                                                     2.how many mambers without vaccine- בפעולה זו הייתי צריכה למנות כמה מהחברים אינם מחוסנים כלל
התוצאה גם פה תחזור בconsole(לחיצה על 12 F)

 ![alt text](./pictures/צילום מסך 2023-05-11 025844.png)
 
