---
layout: default
title: Метод Account.SetSilenceMode
permalink: account/setSilenceMode/
comments: true
---
# Метод Account.SetSilenceMode
Отключает push-уведомления на заданный промежуток времени.

Страница документации ВКонтакте [account.setSilenceMode](https://vk.com/dev/account.setSilenceMode).
## Синтаксис
``` csharp
public bool SetSilenceMode(
	[NotNull] string deviceId,
	int? time = null,
	int? chatId = null,
	int? userId = null,
	bool? sound = null
)
```

## Параметры
+ **deviceId** - Уникальный идентификатор устройства. строка, доступен начиная с версии 5.31
+ **time** - Время в секундах на которое требуется отключить уведомления, -1 отключить навсегда целое число
+ **chatId** - Идентификатор чата, для которого следует отключить уведомления.
+ **userId** - Идентификатор пользователя, для которого следует отключить уведомления.
+ **sound** - 1 - включить звук в данном диалоге, 0 - отключить звук (параметр работает только если указан chat_id или user_id) целое число
+ -----------------------------------
+ **peerId** - Идентификатор назначения. 
Для групповой беседы: 
2000000000 + id беседы. 
Для сообщества: 
-id сообщества. 
 целое число, доступен начиная с версии 5.46

## Результат
Возвращает 1 в случае успешного выполнения метода.

## Пример
``` csharp
// Пример кода
```

## Версия Вконтакте API v.5.45
Дата обновления: 15.02.2016 14:14:52