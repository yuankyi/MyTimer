# MyTimer

|类型|System.Threading.Timer|System.Timers.Timer|System.Windows.Forms.Timer|
|:----|:----|:----|:----|
|原理|多线程|多线程|单线程,基于消息循环机制|
|更新UI|需使用委托|需使用委托|可直接更新UI|
|触发方式|回调函数|绑定事件|绑定事件|
|延迟|可指定延迟,为0时立即执行|延迟Interval后第1次执行(可先执行,再启动timer,实现立即执行)|延迟Interval后第1次执行(可先执行,再启动timer,实现立即执行)|
|执行|Interval间隔后,开启新的线程执行,不管上一次是否执行完毕,要求处理程序可重入(可通过处理程序自行停止和开启timer控制)|Interval间隔后,开启新的线程执行,不管上一次是否执行完毕,要求处理程序可重入(可通过处理程序自行停止和开启timer控制)|下一次会等上一次执行完才开始,实际执行间隔为Max(当前执行时间,Interval)|
|特点|简单方便轻量级|基于Threading.Timer的封装拓展|线程安全,不能执行复杂处理,会影响UI响应|
|适用|all|all|windowsform|
