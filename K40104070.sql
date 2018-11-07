CREATE DATABASE ADBTeam27SpatialDB
use ADBTeam27SpatialDB
CREATE TABLE QLD
(
	MaMucDich nchar(10) primary key,
	YnghiaMucDich nvarchar(200),
	MatDoLuongNuocTuoiTieu int,
	MatDoDoanhThu float,
	ViTriDiaLy geometry
)

INSERT INTO QLD (MaMucDich, YnghiaMucDich, MatDoLuongNuocTuoiTieu, MatDoDoanhThu, ViTriDiaLy)
VALUES ('M7', N'Trồng Lúa', 45000, 250.6, geometry::STGeomFromText('POLYGON ((-7 2, 4 2, 2 1, 4 0, -7 0, -5 1, -7 2))',0)),
	   ('M8', N'Trồng Cây Ăn Quả', 30000, 350.4, geometry::STGeomFromText('POLYGON ((4 2, 0 2, 3 9, 8 6, 5 7, 4 2))',0)),
	   ('M9', N'Trồng Rau', 60000, 450.5, geometry::STGeomFromText('POLYGON ((4 2, 2 1, 4 0, 7 -5, 8 -4, 9 1, 4 2))',0)),
	   ('M10', N'Trồng Xoài', 75000, 400.5, geometry::STGeomFromText('POLYGON ((4 2, 5 7, 8 6, 9 1, 4 2))',0));
SELECT * FROM QLD;

/* câu 2 */
/* a */
SELECT MaMucDich, MatDoLuongNuocTuoiTieu
FROM QLD

/* b */
SELECT *
FROM QLD
WHERE ViTriDiaLy.STArea() >= ALL (SELECT ViTriDiaLy.STArea() FROM QLD)

