# 6번 문제

주어진 프로젝트는 다음의 기능을 구현하고자 생성한 프로젝트이다.

### FPS 조작 구현
- 실행 시, 마우스 커서가 비활성화되며 마우스 회전으로 플레이어의 시야가 회전한다.
- 현재 바라보고 있는 방향 기준으로 W, A, S, D로 전, 후, 좌, 우 이동을 수행한다
- 마우스 좌클릭 시, 시야 정면 방향으로 레이를 발사하고 레이캐스트에 검출된 적의 이름을 콘솔에 로그로 출력한다.

위 기능들을 구현하고자 할 때
제시된 프로젝트에서 발생하는 `문제들을 모두 서술`하고 올바르게 동작하도록 `소스코드를 개선`하시오.

## 답안
1. 카메라와 플레이어가 연동되지 않아 플레이어의 시야를 표현하지 못한다.
2. Gun의 LayerMask 설정이 완료되지 않아 적을 검출하지 못한다.
3. Ray의 진행방향이 플레이어가 바라보는 방향이 아닌 월드좌표계의 앞 방향으로 설정돼있다.