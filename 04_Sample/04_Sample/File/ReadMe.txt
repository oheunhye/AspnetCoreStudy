파일 입출력은 닷넷프레임워크에서 공통적으로 제공하는 네임스페이스를 사용

파일 입출력처리 작업
DB에 문제가 있을 경우 또는 특별한 상황에서 파일을 통해 자료를 가져오고 저장할 수 있음
System.IO 네임스페이스에 파일입출력 관련 클래스 정의
텍스트 파일 관련한 내용은 System.Text 네임스페이스에 클래스 정의

-System.IO.Stream클래스와 FileStream관계
Stream안에 FileStream(디스크 파일에 데이터를 기록)이 포함된다.

-FileStream클래스의 인스턴스 생성
Stream 스트림객체명 = new FileStream("파일명", FileMode);
파일명					:읽거나 출력할 파일명 기술
FileMode				:파일의 여는 방법 표시
	FileMode.create		:새 파일 생성
	FileMode.open		:파일 열기
	FileMode.truncate	:파일을 비워서 열기
	FileMode.append		:덧붙이기 모드로 열기

-파일스트림을 통한 파일 읽고 쓰기는 배열로 처리한다
읽기 open-read-close	/ 쓰기 create-write-close


-텍스트 파일 처리를 위한 StreamReader와 StreamWriter클래스
StreamWriter	:스트림에 텍스트 파일을 기록하기 위한 클래스(저장)
StreamReader	:스트림으로부터 텍스트파일을 읽어들이기 위한 클래스
일종의 보조 클래스이므로 이들을 이용하기 위해서는 *FileStream의 인스턴스가 필요*

-텍스트 파일안에 내용 읽어오기
FileStream file = new FileStream("파일명", FileMode.Open);
StreamReader sin = new StreamReader(file);
sin.Read(); 또는 sin.ReadLine();
sin.Close();

-파일에 텍스트를 출력하기
FileStream file = new FileStream("파일명", FileMode.Create);
StreamWrite sout = new StreamWrite(file);
sout.Write(); 또는 sout.WriteLine();
sout.Close();