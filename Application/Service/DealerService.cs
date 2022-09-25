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

	public Task<bool> CreateDealer(DealerDTO dealerDTO)
	{
		return dealerRepository.CreateDealer(dealerDTO);
	}

	public Task<List<CarViewDTO>> DealerCars()
	{
		return dealerRepository.DealerCars();
	}

	public Task<bool> IsDealer(string id)
	{
		return dealerRepository.IsDealer(id);
	}
}
