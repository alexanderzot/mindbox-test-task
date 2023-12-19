/* RECREATING TABLES */

DROP TABLE IF EXISTS link_categories_products;
DROP TABLE IF EXISTS categories;
DROP TABLE IF EXISTS products;

CREATE TABLE categories
(
  category_id INT NOT NULL PRIMARY KEY,
  name NVARCHAR(50) NOT NULL UNIQUE,
);

CREATE TABLE products
(
  product_id INT NOT NULL PRIMARY KEY,
  name NVARCHAR(100) NOT NULL UNIQUE,
);

CREATE TABLE link_categories_products
(
  category_id INT FOREIGN KEY REFERENCES categories(category_id),
  product_id INT FOREIGN KEY REFERENCES products(product_id),

  CONSTRAINT link_categories_products_pk PRIMARY KEY (category_id, product_id)
);

/* INSERT DATA */

INSERT INTO categories(category_id, name)
VALUES
    (1, N'Фрукты'),
    (2, N'Овощи'),
    (3, N'Напитки'),
    (4, N'Акция');

INSERT INTO products(product_id, name)
VALUES
    (1, N'Яблоки'),
    (2, N'Мандарины'),
    (3, N'Бананы'),
    (4, N'Капуста'),
    (5, N'Незамерзайка');

INSERT INTO link_categories_products
VALUES
    (1, 1), -- Фрукты Яблоки
    (1, 2), -- Фрукты Мандарины
    (1, 3), -- Фрукты Бананы
    (4, 3), -- Акция Бананы
    (2, 4); -- Овощи Капуста


/* QUERY */

SELECT p.name as product_name, c.name as category_name
FROM products as p
    LEFT JOIN link_categories_products as l
    ON p.product_id = l.product_id

    LEFT JOIN categories as c
    ON l.category_id = c.category_id;