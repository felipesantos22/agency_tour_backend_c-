using agency.DataContext;
using agency.Models;
using Microsoft.EntityFrameworkCore;

namespace agency.Repository;

public class TourRepository
{
    private readonly DataContext.DataContext _dataContext;
    
    public TourRepository(DataContext.DataContext context)
    {
        _dataContext = context;
    }

    public async Task<Tour> Create(Tour tour)
    {
        await _dataContext.Tours.AddAsync(tour);
        await _dataContext.SaveChangesAsync();
        return tour;
    }
    
    public async Task<List<Tour>> Index()
    {
        var tour = await _dataContext.Tours.ToListAsync();
        return tour;
    }
    
    
}