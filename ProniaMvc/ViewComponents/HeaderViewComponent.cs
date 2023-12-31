﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaMvc.DataAccess;

namespace ProniaMvc.ViewComponents;

public class HeaderViewComponent : ViewComponent
{
    readonly ProniaDbContext _context;
    public HeaderViewComponent(ProniaDbContext context)
    {
        _context = context;
    }
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View(await _context.Settings.ToDictionaryAsync(s => s.Key, s => s.Value));
    }
}
