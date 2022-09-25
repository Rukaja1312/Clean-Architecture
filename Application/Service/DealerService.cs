using Application.DTOs;
using Application.Interfaces;
using Project2.Application.Interfaces;

namespace Project2.Application.Service;
public class DealerService : IDealerService
{
	private readonly IDealerRepository dealerRepository;

	public DealerService(IDealerRepository dealerRepository)
	{
		this.dealerRepository = dealerRepository;
	}

	public async Task<bool> CreateDealer(DealerDTO dealerDTO)
	{
		return await dealerRepository.CreateDealer(dealerDTO);
	}

	public async Task<List<CarViewDTO>> DealerCars()
	{
		return await dealerRepository.DealerCars();
	}

	public async Task<bool> IsDealer(string id)
	{
		return await dealerRepository.IsDealer(id);
	}
}
