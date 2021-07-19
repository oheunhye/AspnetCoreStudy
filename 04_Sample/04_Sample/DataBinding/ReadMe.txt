1 데이터 바인딩
DB와 DB안의 내용을 실제로 컨트롤을 통해 페이지에 보여준다.
데이터 값과 서버컨트롤을 연결
서버 컨트롤의 DataSource속성에 참조할 데이터를 지정.


-데이터소스 컨트롤 이용한 데이터 표시작업
SqlDataSource컨트롤을 배치하고 데이터소스구성에서

1.SqlDataSource컨트롤
웹 서버 컨트롤을 사용하여 데이터베이스의 데이터에 액세스가능(화면에 뿌리는건 불가능)
DataSource는 데이터베이스의 데이터를 의미
**SqlDataSource컨트롤 + 데이터 보여주는 '데이터컨트롤' = 바인딩하여 웹 페이지에 결과보여줌

-표현 데이터컨트롤 
DataList	:테이블형태로 반복적 데이터 행동을 표시, 목록형태
DatailsView	:데이터소스에서 레코드들을 한 번에 하나씩 표시, 많아도 한줄로
FormView	:DetailsView처럼 데이터소스의 단일 레코드 형태로 표시, 칼럼형태
GridView	:테이블 형태로 데이터 소스의 값들을 표시(각 소스의 값들을 선택,정렬,편집가능)
Repeater	:템플릿 기반으로 데이터소스 바운드하여 목록표시, 레이아웃개념이 부족하여 코딩해줘야함.

1)DataList
데이터 소스로부터 데이터를 읽어 보여주는 컨트롤
템플릿 이용하여 데이터를 어떻게 보여줄 것인지 형식지정
	-종류	-->자동서식도 가능
	*ItemTemplate			:데이터 항목을 보여줄 템플릿
	AlternationItemTemplate	:열 값을 보여줄 때 번갈아 다른 형식으로 보여주고자 할 때 사용
	HeaderTemplate			:리스트 맨위에 위치하여 제목을 보여줌
	FooterTemplate			:데이터 항목 보여준 후 나타낼 내용
	SeperatorTemplate		:데이터 항목과 항목 사이에 보여줄 템플릿
	SelectedItemTemplate	:사용자가 선택한 임의의 데이터 항목을 보여줄 템플릿

2)Gridview
데이터소스로부터 데이터를 읽어서 테이블 형태로 화면에 표시
행-레코드, 열-필드로 구성
행 단위로 데이터 선택/편집이 가능
	-데이터
	DataSourceID			:연결할 데이터 소스컨트롤의 ID
	-페이징
	AllowPaging				:행의 길이가 길어질때 페이지 나누기 허용
	PageSize				:한 페이지에 표시할 행의 갯수
	-동작
	AllowSorting			:데이터 정렬기능 결정
	AutoGernerateColumns	:열머리글 자동지정