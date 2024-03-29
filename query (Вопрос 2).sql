/*В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может 
быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта - Имя категории». Если у продукта нет категорий, то его имя 
все равно должно выводиться.*/

SELECT
	 prdct.name AS productName
	,ctg.name AS categoryName
FROM tProduct AS prdct
LEFT JOIN tProductCategotyLink AS pcl
	ON pcl.productId = prdct.id
LEFT JOIN tCategory AS ctg
	ON pcl.categoryId = ctg.id