select * from ADMIN
--1
ALTER TABLE ADMIN
ALTER COLUMN MatKhau NVARCHAR(100);
--2
-- ⚠ CHỈ CHẠY LỆNH NÀY DUY NHẤT 1 LẦN
UPDATE ADMIN
SET MatKhau = CONVERT(
                  VARCHAR(100),
                  HASHBYTES('SHA2_256', MatKhau),2 -- style 2: trả về HEX, không có '0x' ở đầu
              );
