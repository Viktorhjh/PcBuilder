using Application.Repositories;
using Core.Entities;
using Infrastructure.Data;
using Infrastructure.Interfaces;

public class MotherboardRepository(PcBuilderDbContext dbContext) : GenericRepository<Motherboard>(dbContext), IMotherboardRepository { }