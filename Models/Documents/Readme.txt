(1)

Make some changes in your models.

بعد از اعمال تغییرات، به هیچ عنوان پروژه را اجرا نکنید

(2)

Compile Solution.

Note: Your project should not have any warnings and errors.

(3)

Note: After runing Nuget, Select Models project

(4)

PM> Add-Migration -Name VersionXXX

(5)

فایل ایجاد شده را باز کرده و تغییرات لازم را در داخل آن اعمال می‌کنیم

دقت کنید که نمی‌توانیم به جدولی که احتمالا در نسخه قبلی در اختیار مشتری قرار گفته

و به احتمال زیاد اطلاعاتی دارد، فیلد غیر

Null

اضافه کنیم. لذا یا باید آن فیلد جدید را

Nullable

تعریف کرده و یا برای آن

DefaultValue and DefaultDatabaseValue

تغیین نماییم

(6)

نکته خیلی مهم

قبل از تغییرات دیگری در مدل، حتما یکبار پروژه را اجرا نمایید

-----------------------------------------------------------------

Wrong:

	Making Some Changes in Models -> Add Migration -> 
	Making Some Changes in Models -> Add Migration ->
	...
	Run Application!!!

Right:

	Making Some Changes in Models -> Add Migration -> 
	Run Application!!!
	Making Some Changes in Models -> Add Migration ->
	Run Application!!!
	...
