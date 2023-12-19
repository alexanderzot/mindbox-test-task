## Вопрос №1
> Был ли у вас опыт веб-разработки? Приложите ссылку на репозиторий с вашим веб-проектом, если возможно.

Был, но могу только на [старый проект](https://github.com/alexanderzot/DocumentClassifierTesting) приложить ссылку.

## Вопрос №2
> Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.

Смущает только фраза:
> Вычисление площади фигуры без знания типа фигуры в compile-time

Если тут (*вычисления без знания типа фигуры*) - речь идет про динамический полиморфизм, то он работает в рантайме, а не в компайл-тайме.
Поэтому сделал предположение, что в конце опечатка.

Покрытие модульными тестами:
![Coverage](./images/coverage.png "Coverage")

## Вопрос №3
> В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
> По возможности — положите ответ рядом с кодом из первого вопроса.

Полный листинг доступен [тут](./query.sql), сам запрос:
```sql
SELECT p.name as product_name, c.name as category_name
FROM products as p
    LEFT JOIN link_categories_products as l
    ON p.product_id = l.product_id

    LEFT JOIN categories as c
    ON l.category_id = c.category_id;
```

Вывод для данных из приложенного файла будет примерно таким:

| product_name | category_name |
|:------------:|:-------------:|
|    Бананы    |    Фрукты     |
|    Бананы    |     Акция     |
|   Капуста    |     Овощи     |
|  Мандарины   |    Фрукты     |
| Незамерзайка |    *NULL*     |
|    Яблоки    |    Фрукты     |

## Вопрос №4
> Готовы ли выйти на фуллтайм (удаленно/офис/гибрид) в случае успешного завершения стажировки через 3-4 месяца?
 
Готов.