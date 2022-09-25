using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project2.Application.Interfaces;

namespace Project2.Application.Service;
public class CarService : ICarService
{
	private readonly ICarRepostory carRepostory;

	public CarService(ICarRepostory carRepostory)
	{
		this.carRepostory = carRepostory;
	}

	public  SelectList BrandList()
	{
		return carRepostory.BrandList();
	}

	public async Task<bool> CarCreate(CarCreateDTO carCreateDTO)
	{
		return await carRepostory.CarCreate(carCreateDTO);
	}

	public async Task<bool> Delete(int id)
	{
		return await carRepostory.Delete(id);
	}

	public async Task<Car> DeleteGet(int id)
	{
		return await carRepostory.DeleteGet(id);
	}

	public async Task<bool> Edit(int carId, CarEditDTO carEditDTO)
	{
		return await carRepostory.Edit(carId, carEditDTO);
	}

	public async Task<CarEditDTO> Edit(int id)
	{
		return await carRepostory.Edit(id);
	}

	public async Task<List<CarViewDTO>> GetAllCars()
	{
		return await carRepostory.GetAllCars();
	}

	public async Task<List<CarViewDTO>> SortByBrand(int? id)
	{
		return await carRepostory.SortByBrand(id);
	}
}
