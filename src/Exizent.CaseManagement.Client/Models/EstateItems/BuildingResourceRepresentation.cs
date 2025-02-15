﻿using Dahomey.Json.Attributes;

namespace Exizent.CaseManagement.Client.Models.EstateItems;

[JsonDiscriminator(nameof(EstateItemType.Building))]
public class BuildingResourceRepresentation : EstateItemResourceRepresentation
{
    public AddressResourceRepresentation Address { get; init; } = null!;
    public string? ResidenceType { get; init; }
    public string? ConveyancingDescription { get; init; }
    public bool IsMainResidence { get; init; }
    public bool IsVacant { get; init; }
    public bool IsRented { get; init; }
    public PropertyProprietorship Proprietorship { get; init; }
    public PropertyPurpose Purpose { get; init; }
    public decimal? ExecutorEstimatedValue { get; init; }
    public decimal? ZooplaEstimatedValue { get; init; }
    public decimal? SurveyorFormalValue { get; init; }
    public string? FormalValuationBy { get; init; }
    public bool HasAdvisedInsurance { get; init; }
    public bool HasAdvisedUtilities { get; init; }
    public bool HasAdvisedCouncil { get; init; }
    public bool HasAdvisedCommsSuppliers { get; init; }
    public bool ContainsMoveableItems { get; init; }
    public decimal ProportionOwned { get; init; }
    public bool? IsValidForInheritanceTax { get; init; }
    public decimal? GrossSaleProceeds { get; init; }
    public bool IsFarmOrFarmhouse { get; init; }
    public bool IsFreehold { get; init; }
    public int? LengthOfLease { get; init; }
    public decimal? AnnualRent { get; init; }
    public DateTime? DateTenancyBegan { get; init; }
    public DateTime? DateTenancyEnds { get; init; }
    public decimal? MonthlyRent { get; init; }
    public bool AgriculturalBusinessOrHeritageReliefExemption { get; init; }
    public decimal? BusinessReliefValue { get; init; }
    public decimal? HeritageExemptionValue { get; init; }
    public decimal? AgriculturalReliefValue { get; init; }
    public decimal? WoodlandsReliefValue { get; init; }
    public bool IsSubjectToSpecialFactors { get; init; }
    public string? SpecialFactorsDescription { get; init; }
    public bool IsCharityDonation { get; init; }
}