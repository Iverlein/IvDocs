/*Найдите номер модели, скорость и размер жесткого диска для всех ПК стоимостью менее 500 долларов. Вывести: model, speed и hd */
SELECT model, speed, hd
FROM pc
WHERE price < 500
ORDER BY model
/*Найдите производителей принтеров. Вывести: maker.*/
SELECT maker
FROM product
WHERE type = 'Printer'
/*Найдите номер модели, скорость и размер жесткого диска ПК, имеющих 12х или 24х CD и цену менее 600 долларов*/
SELECT model, speed, hd
FROM pc 
WHERE 
    cd = IN('12x','24x')
    AND price < 600
ORDER BY model
/*Найдите производителя, продающего ПК, но не ноутбуки*/
SELECT maker
FROM product
WHERE type = 'PC'
ORDER BY maker
/*Найдите среднюю скорость ПК, выпущенных производителем A*/
SELECT AVG(speed)
FROM pc
WHERE 
    model = IN(SELECT model FROM product WHERE maker = 'A')
AS Average_Speed_Of_A_PCs