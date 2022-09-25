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

	public Task<SelectList> BrandList()
	{
		return carRepostory.BrandList();
	}

	public Task<bool> CarCreate(CarCreateDTO carCreateDTO)
	{
		return carRepostory.CarCreate(carCreateDTO);
	}

	public Task<bool> Delete(int id)
	{
		return carRepostory.Delete(id);
	}

	public Task<Car> DeleteGet(int id)
	{
		return carRepostory.DeleteGet(id);
	}

	public Task<bool> Edit(int carId, CarEditDTO carEditDTO)
	{
		return carRepostory.Edit(carId, carEditDTO);
	}

	public Task<CarEditDTO> Edit(int id)
	{
		return carRepostory.Edit(id);
	}

	public Task<List<CarViewDTO>> GetAllCars()
	{
		return carRepostory.GetAllCars();
	}

	public Task<List<CarViewDTO>> SortByBrand(int? id)
	{
		return carRepostory.SortByBrand(id);
	}
}
