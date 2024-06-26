﻿using BlogApp.Application.Services;
using Microsoft.AspNetCore.Mvc;

public class NotificationController : Controller
{
    private readonly NotificationService _notificationService;

    public NotificationController(NotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    [HttpPost]
    public async Task<IActionResult> Notify()
    {
        await _notificationService.NotifyAllAsync("This is a notification!");
        return Ok();
    }
}
