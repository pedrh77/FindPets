﻿using CoreAPI.Features.LostAnimalReports.Models;

namespace CoreAPI.Features.LostAnimalReports.Contracts;

public interface ILostAnimalReportRepo
{
    Task<IList<LostAnimalReport>> ListLostAnimalAsync();
}
