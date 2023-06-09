using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF7Relationships.Data;
using EF7Relationships.DTOs;
using EF7Relationships.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EF7Relationships.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EF7RelationshipsController : ControllerBase
{
    private readonly DataContext _context;

    public EF7RelationshipsController(DataContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<ActionResult<List<Character>>> CreateCharacter(CharacterCreateDto request)
    {
        var newCharacter = new Character
        {
            Name = request.Name,
        };

        var backpack = new Backpack { Description = request.Backpack.Description, Character = newCharacter };

        newCharacter.Backpack = backpack;
        _context.Characters.Add(newCharacter);
        await _context.SaveChangesAsync();

        return Ok(await _context.Characters.Include(c => c.Backpack).ToListAsync());
    }
}