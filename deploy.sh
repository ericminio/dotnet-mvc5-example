ftp -v ftp://ericmvc5-001:Yose12345@ftp.mywindowshosting.com <<-ENDTAG
binary
prompt
cd site1

lcd Yose

put Web.config
put Global.asax

cd bin
lcd bin
put Yose.dll

ENDTAG
