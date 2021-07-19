1 DataBase

Application >DB연결작업/sql명령실행> DBMS
			<<<<<<<<<명령결과<<<<<<<
			>>>>>DB연결해제작업>>>>>

-ASP.NET데이터베이스 접근방법

ASP.NET웹응용프로그램 > ADO.NET >>공급자 통한 연결/쿼리실행>> 데이터 소스(MySQL,MSSQL,Oracle)
ADO.NET:연결해주는 중간 매개 역할
공급자는 어떤 DB를 쓰냐에 따라 다름.

-DATABASE
서로 관련성 있는 광범위한 데이터들을 모아놓은 *저장소*
DB와 네트워크가 연관성을 갖고 사용됨 -> 빅데이터

-DBMS (=ADO.NET)
응용프로그램 또는 사용자와 DB간의 인터페이스를 수행하기 위한 종합적 패키지 또는 프로그램을 의미.
데이터베이스 생성, 유지보수, 제어 및 사용을 위한 프로그램
DB <-> DBMS <- SQL ->쇼핑몰 웹 서버/포탈 사이트 프로그램/웹 애플리케이션 <-> 사용자

-데이터베이스 세부구조
테이블	: 관련있는 필드의  집합+데이터 -> 테이블 생성/수정/삭제
데이터가 저장되는 그릇을 의미 -> 스키마에 테이블 구조정보 기록.
스키마	: 저장,수정, 전반적 구조, 테이블 작성정보가 저장되는 공간.
필드명	: 테이블을 구성하는 항목 -> 필드 데이터 타일을 고려
레코드	: 각 필드영역에 입력되는 데이터들의 집합 -> 레코드삽입, 삭제, 변경

----------------------------------------------------------------------------------------------------

2 ASP.NET DB개요와 연동+

-ADO.net개요
ADO.NET은 .NET프로그래머에게 데이터 액세스 서비스를 지원하는 일종의 클래스 집합.
ADO.NET은 분산된 데이터 공유 응용 프로그램을 만들기 위한 다양한 구성 요소를 제공.
관계형, XML 및 응용 프로그램 데이터에 대한 액세스를 제공하는 .NET Framewoek의 핵심 요소.
종래의 ADO기능에 .net의 기능을 가미하여 보다 폭넓은 기능을 제공.

   dataSet					.net DB Provider(제공자)
...........................................................................
	table		<-->		Data Adapter
  -DataRow					Data Reader
  -Collection				
  -DataColumn				 Command
  -Collrection					|
							Connection			<-->		DataSource


-공급자(Provider) 정의와 종류
데이터 소스에 연결하는 명령실행과 데이터 검색에 사용.
.net Framework 데이터 공급자				: 설명
.NET Framework Data Provider for SQL Server	:Microsoft SQL Server에 대한 데이터 액세스를 제공.
											 System.Data.SqlClient 네임스페이스 사용.
.NET Framework Data Provider for OLE DB		:OLE DB를 사용하여 노출된 데이터 소스에 사용
											 System.Data.OleDb
.NET Framework Data Provider for ODBC		:Odbc를 사용해 데이터 액세스 제공
											 System.Data.Odbc
.NET Framework Data Provider for Oracle		:Oracle 데이터 소스에서 사용
											 System.Data.OracleClient

-데이터 공급자의 주요 개체
개체						: 설명
Connection -> DbConnection	:특정 데이터 소스에 연결
Command	   -> DbCommand		:데이터 소스에 대해 쿼리 명령을 실행
DataReader -> DbDataReader	:데이터 소스에서 데이터 읽기 전용 스트림
DataAdapter-> DbDataAdapter	:DataSet을 채우고 업데이트 내용을 데이터 소스에 적용


-ADO.NET구성 네임스페이스
System.Data				:DataSet, DataTable, DataRow등 핵심 주요 Class가 이곳에 존재함.

System.Data.SqlClient	:Sql server.net데이터 공급자를 작성하는 타입을 가짐. 
						=SqlConnection, SqlCommand, SqlDataReader, SqlDataAdapter 등

System.Data.OleDb		:Ole.Db.Net데이터 공급자를 구성하는 타입을 가짐.
						=OleDBConnection, OleDBCommand, OleDBDataReader, OleDBDataAdapter 등

System.Common			:.NET데이터공급자에 의해 공유된 클래스 존재
System.Data.SqlTypes	:SQL Server에서 사용되는 고유데이터타입들을 가짐.

----------------------------------------------------------------------------------
*ASP.NET Application에서 sql서버 연결을 위한 작업
-데이터 제공자는 데이터소스에 연결하고 명령을 실행하며 데이터 검색하는 역할 수행
-sql서버 데이터소스에 연결하기 위해서는 sqlConnection클래스 제공
-ASP.NET에서 위 클래스 사용을 위해 System.Data.SqlClient네임스페이스 포함시켜야함

데이터베이스연결 >> 쿼리실행작업(command) >> 데이터베이스연결해제
sqlConnection 연결객체명 = new sqlConnection(연결정보);
연결객체명.Open();

1.sql서버 연결을 위한 네임스페이스 기술
using System.Data;
using System.Data.SqlClient;

2.데이터베이스 서버이름, 사용자 아이디와 암호, 연결할 데이터베이스명 기술
	1)sql서버 2008의 연동작업
	"Server=localhost;UID=sa;PWD=암호기술;database=데이터베이스명";

	2)sql서버 2008 express연결
	Data Source=.\sqlexpress;Initial Caltalog=데이터베이스명;Intergrated Security=True;
	Data Source=.\sqlexpress;AttachDbFileName=데이터베이스파일명;Intergrated Security=True;User Instance=True

	데이터베이스 서버를 로컬서버 데이터소스로 지정.
	Intial Catalog-연결할 데이터베이스 명 기술(AttachDbFileName을 기술해도 되나 데이터베이스 파일명을 기술)
	Intergrated Security-기본값 false, flase면 SQL Server인증방식을 사용하여 연결시 사용자의 ID와 암호를 지정해야함.
	true인경우 windows인증을 사용
	User Instance-사용자 인스턴스 사용여부

*Sql서버에 대한 명령실행
-데이터 제공자는 sql서버에 데이터 명령을 실행하기 위해 SqlCommand클래스 제공
-데이터 제공자는 sql서버에서 특정 데이터를 읽어오기 위한 sqlDataReader클래스 제공

sqlCommand 명령실행객체명 = new sqlCommand(명령, 연결객체);
sqlDataReader 읽기객체명 = 명령실행객체명.메소드();

-SqlCommand클래스의 주요 메소드
메소드명	:기능
ExecuteReader	:명령처리결과 행을 반환
ExecuteNonQuery	:행 반환이 없음(insert,update,delete명령시 사용)
ExecuteScalar	:처리결과 어떤 항목의 합계, 갯수와 같은 맨 첫번째 행 첫 열을 반환
