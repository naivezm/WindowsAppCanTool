# Cantool Windows App 设计说明

> 软件名称: windows app 小组成员：胡庆庆 张德胜 王杰 李耀

## 1. 引言

### 1.1 项目背景

在汽车控制技术中，汽车中会使用多个电子控制装置对整车进行控制。ECU之间的信息交换依赖于CAN(Controller Area Network)总线的网络连接方式来完成。为了检测和控制CAN bus的信息内容，需要使用CAN bus检测设备。CanTool装置是完成CANbus检测的工具。为了实现CAN数据的显示及控制，需要使用本文提出的CanToolApp软件

### 1.2 编写目的

将连接在CAN总线上的CanTool装置采集的CAN信息发送到上位机（Windows PC），并由运行在上位机中的CanToolApp软件接收这些信息，显示在用户图形界面上

## 2. 软件概述

cantool app 可在 windows 系统上正常运行， 用于串口装置信息的接收发送及设置。软件基于 vs2015 开发，.net framework 版本为 4.5，使用dev控件

## 3.需求分析

具体需求分析在需求文档中

![image](http://om0ttwn6c.bkt.clouddn.com/%E4%BE%8B%E5%9B%BEcantool.png
)

## 4.功能介绍

### 4.1 软件总体介绍

我们的 CantoolApp 使用可视化 GUI 界面实现了对来自串口信息的实时显示和读写，项目主要分为
- 基本设置模块
- Can 信息原始数据显示模块
- CAN 信号仪表盘和信号曲线显示
- CAN 信息接发模块

完成的主要功能有
- 将接收到的 Can 信息保存到数据库中
- Can 信息的实时显示和解析
- Cantool 装置 Com 口的初始化设置
- 用户数据库 Can 信息的实时显示
- 发送 Can 信息的物理值设置
- CantoolApp 与 Cantool 装置的通讯
- CAN 信号在 CAN 信息中的布局
### 4.2 基本设置模块

在这个模块里我们的主要功能有在下拉列表中
选择本机可用 COM 口
并可以设定相应 COM 口的波特率 115200, 数据位数 8, 停止位数 1 , 同时这些设置可以保存在设定文件中，当下一次重启时可以自动填充。

![image](http://om0ttwn6c.bkt.clouddn.com/123456.png
)

### 4.3 Can 信息原始数据显示模块

在该模块里我们完成了对接收到的 CAN 信息的实时显示及 CAN 信号数据库的解析

![image](http://om0ttwn6c.bkt.clouddn.com/L$FBUE$$K20~P1%5D23~Y%28%25Q4.png
)

### 4.4 CAN 信号仪表盘和信号曲线显示

CAN 信号的显示，是用 linq 的方式连接 sql 数据库，通过对数据库的解析，我们讲 CAN 信号的物理值用 dev 中的仪表盘和曲线插件显示出来

![image](http://om0ttwn6c.bkt.clouddn.com/452O9CSUKJP5ZC%29U%5DO%7DPBFL.png)

![image](http://om0ttwn6c.bkt.clouddn.com/1%29F~4@8BQF8ZVB%28J0%60C2JXH.png)

### 4.5 CAN 信息接发模块

CAN 信息的接发模块是我们整个系统的最重要的一部分，在这个模块里我们完成了对 CanToolApp 与串口的通讯，GUI 界面显示用户提供的 CAN 信号和信息数据库，将用户设定的 CAN 物理值整合为 CAN 信息发送给CANTOOL 装置

![image](http://om0ttwn6c.bkt.clouddn.com/%5D_S1A34GZ3%5BLYDT9JIS%294AG.png
)

用户可以通过我们的发送框向 Cantool 装置发送各种指令。同时在模块的左边我们通过 treeView 的形式将用户提供的数据库展示了出来，通过点击Can 信息，我们进入可以进入到 Can 信息的物理值设置界面，设置完毕后 Can 信息能够转到发送框中，由我们向 CanTool 装置发送。

![image](http://om0ttwn6c.bkt.clouddn.com/1%7B$%7BOE_QX~76WM%5D2WFY@7B0.png
)

![image](http://om0ttwn6c.bkt.clouddn.com/%7D%7D~36X%25UX%7B%25%60B%60%60RMPKZZ7X.png)

### 4.6 CAN 信号在 CAN 信息中的布局

通过解析，我们将 CAN 信号在 CAN 信息中的布局用画布的方式画在了以下界面中

![image](http://om0ttwn6c.bkt.clouddn.com/LYHMU$3$N%5B~H18%602595@L%28O.png)
