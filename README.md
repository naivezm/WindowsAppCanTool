# Cantool Windows APP 项目需求文档

> 小组成员：胡庆庆，张德胜，李耀，王杰

## 图表分析

```
graph TB
A{CAN 总线}-->B(CanTool装置)
B --> | UART/蓝牙串口 | C[上位机 CanTool App]
C --> D[基本设置]
C --> E[CAN 信息接收]
C --> F[CAN 信息发送]
C --> G[加载信息]
C --> H[远程数据共享]
C --> I[功能变更]
D --> J[遍历本机<br>可用COM口,<br/>确定CanTool<br>装置在上<br>位机中映<br>射的COM<br>口设置<br/>相应参数<br>保存]
D --> K[实现CanTool<br>装置的<br>CAN速率<br>设置和状<br>态设置]
E --> FF[对接受的<br>CAN信息<br>解析并显<br>示其物理<br>值后保存]
E --> FFF[以不同形<br>式显示选<br>定的CAN信<br>号的物理<br>值及其变化]
F --> KKK[用户设置<br>CAN信号<br>的物理值<br>和发送周期]
F --> KK[将物理值<br>转换为CAN<br>信号值,并<br>组装完成<br>CAN信息发送]
G --> GG[加载用户<br>提供CAN<br>信号和<br>信息数据库]
G --> GGG[表格形式<br>显示CAN<br>信号在信<br>息中的布<br>局树状显<br>示CAN信息<br>的结构]
G --> GGGG[数据保存<br>以及数据<br>格式的转<br>换]
```