using System.Collections.Generic;
using Newtonsoft.Json;

// ReSharper disable InconsistentNaming

namespace SAM_Console_Test
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class EntityRegistration
    {
        [JsonProperty("ueiSAM")]
        public string UeiSAM { get; set; }

        [JsonProperty("ueiDUNS")]
        public string UeiDUNS { get; set; }

        [JsonProperty("entityEFTIndicator")]
        public object EntityEFTIndicator { get; set; }

        [JsonProperty("cageCode")]
        public string CageCode { get; set; }

        [JsonProperty("dodaac")]
        public object Dodaac { get; set; }

        [JsonProperty("legalBusinessName")]
        public string LegalBusinessName { get; set; }

        [JsonProperty("dbaName")]
        public string DbaName { get; set; }

        [JsonProperty("purposeOfRegistrationCode")]
        public string PurposeOfRegistrationCode { get; set; }

        [JsonProperty("purposeOfRegistrationDesc")]
        public string PurposeOfRegistrationDesc { get; set; }

        [JsonProperty("registrationStatus")]
        public string RegistrationStatus { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDate { get; set; }

        [JsonProperty("lastUpdateDate")]
        public string LastUpdateDate { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }

        [JsonProperty("activationDate")]
        public string ActivationDate { get; set; }

        [JsonProperty("noPublicDisplayFlag")]
        public string NoPublicDisplayFlag { get; set; }

        [JsonProperty("exclusionStatusFlag")]
        public object ExclusionStatusFlag { get; set; }

        [JsonProperty("exclusionURL")]
        public object ExclusionURL { get; set; }
    }

    public class EntityInformation
    {
        [JsonProperty("entityURL")]
        public object EntityURL { get; set; }

        [JsonProperty("entityDivisionName")]
        public object EntityDivisionName { get; set; }

        [JsonProperty("entityDivisionNumber")]
        public object EntityDivisionNumber { get; set; }

        [JsonProperty("entityStartDate")]
        public string EntityStartDate { get; set; }

        [JsonProperty("fiscalYearEndCloseDate")]
        public string FiscalYearEndCloseDate { get; set; }

        [JsonProperty("submissionDate")]
        public string SubmissionDate { get; set; }
    }

    public class PhysicalAddress
    {
        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public object AddressLine2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("stateOrProvinceCode")]
        public string StateOrProvinceCode { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("zipCodePlus4")]
        public object ZipCodePlus4 { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }

    public class MailingAddress
    {
        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public object AddressLine2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("stateOrProvinceCode")]
        public string StateOrProvinceCode { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("zipCodePlus4")]
        public object ZipCodePlus4 { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }

    public class GeneralInformation
    {
        [JsonProperty("entityStructureCode")]
        public string EntityStructureCode { get; set; }

        [JsonProperty("entityStructureDesc")]
        public string EntityStructureDesc { get; set; }

        [JsonProperty("entityTypeCode")]
        public string EntityTypeCode { get; set; }

        [JsonProperty("entityTypeDesc")]
        public string EntityTypeDesc { get; set; }

        [JsonProperty("profitStructureCode")]
        public string ProfitStructureCode { get; set; }

        [JsonProperty("profitStructureDesc")]
        public string ProfitStructureDesc { get; set; }

        [JsonProperty("organizationStructureCode")]
        public object OrganizationStructureCode { get; set; }

        [JsonProperty("organizationStructureDesc")]
        public object OrganizationStructureDesc { get; set; }

        [JsonProperty("stateOfIncorporationCode")]
        public object StateOfIncorporationCode { get; set; }

        [JsonProperty("stateOfIncorporationDesc")]
        public string StateOfIncorporationDesc { get; set; }

        [JsonProperty("countryOfIncorporationCode")]
        public string CountryOfIncorporationCode { get; set; }

        [JsonProperty("countryOfIncorporationDesc")]
        public string CountryOfIncorporationDesc { get; set; }
    }

    public class BusinessTypeList
    {
        [JsonProperty("businessTypeCode")]
        public string BusinessTypeCode { get; set; }

        [JsonProperty("businessTypeDesc")]
        public string BusinessTypeDesc { get; set; }
    }

    public class SbaBusinessTypeList
    {
        [JsonProperty("sbaBusinessTypeCode")]
        public object SbaBusinessTypeCode { get; set; }

        [JsonProperty("sbaBusinessTypeDesc")]
        public object SbaBusinessTypeDesc { get; set; }

        [JsonProperty("certificationEntryDate")]
        public string CertificationEntryDate { get; set; }

        [JsonProperty("certificationExitDate")]
        public object CertificationExitDate { get; set; }
    }

    public class BusinessTypes
    {
        [JsonProperty("businessTypeList")]
        public List<BusinessTypeList> BusinessTypeList { get; set; }

        [JsonProperty("sbaBusinessTypeList")]
        public List<SbaBusinessTypeList> SbaBusinessTypeList { get; set; }
    }

    public class FinancialInformation
    {
        [JsonProperty("creditCardUsage")]
        public string CreditCardUsage { get; set; }

        [JsonProperty("debtSubjectToOffset")]
        public object DebtSubjectToOffset { get; set; }
    }

    public class CoreData
    {
        [JsonProperty("entityInformation")]
        public EntityInformation EntityInformation { get; set; }

        [JsonProperty("physicalAddress")]
        public PhysicalAddress PhysicalAddress { get; set; }

        [JsonProperty("mailingAddress")]
        public MailingAddress MailingAddress { get; set; }

        [JsonProperty("congressionalDistrict")]
        public object CongressionalDistrict { get; set; }

        [JsonProperty("generalInformation")]
        public GeneralInformation GeneralInformation { get; set; }

        [JsonProperty("businessTypes")]
        public BusinessTypes BusinessTypes { get; set; }

        [JsonProperty("financialInformation")]
        public FinancialInformation FinancialInformation { get; set; }
    }

    public class NaicsList
    {
        [JsonProperty("naicsCode")]
        public string NaicsCode { get; set; }

        [JsonProperty("naicsDescription")]
        public object NaicsDescription { get; set; }

        [JsonProperty("sbaSmallBusiness")]
        public string SbaSmallBusiness { get; set; }

        [JsonProperty("naicsException")]
        public string NaicsException { get; set; }
    }

    public class PscList
    {
        [JsonProperty("pscCode")]
        public object PscCode { get; set; }

        [JsonProperty("pscDescription")]
        public object PscDescription { get; set; }
    }

    public class GoodsAndServices
    {
        [JsonProperty("primaryNaics")]
        public string PrimaryNaics { get; set; }

        [JsonProperty("naicsList")]
        public List<NaicsList> NaicsList { get; set; }

        [JsonProperty("pscList")]
        public List<PscList> PscList { get; set; }
    }

    public class GeographicalAreaServed
    {
        [JsonProperty("geographicalAreaServedStateCode")]
        public object GeographicalAreaServedStateCode { get; set; }

        [JsonProperty("geographicalAreaServedStateName")]
        public string GeographicalAreaServedStateName { get; set; }

        [JsonProperty("geographicalAreaServedCountyCode")]
        public object GeographicalAreaServedCountyCode { get; set; }

        [JsonProperty("geographicalAreaServedCountyName")]
        public string GeographicalAreaServedCountyName { get; set; }

        [JsonProperty("geographicalAreaServedmetropolitanStatisticalAreaCode")]
        public object GeographicalAreaServedmetropolitanStatisticalAreaCode { get; set; }

        [JsonProperty("geographicalAreaServedmetropolitanStatisticalAreaName")]
        public string GeographicalAreaServedmetropolitanStatisticalAreaName { get; set; }
    }

    public class DisasterReliefData
    {
        [JsonProperty("disasterRegistryFlag")]
        public string DisasterRegistryFlag { get; set; }

        [JsonProperty("bondingFlag")]
        public string BondingFlag { get; set; }

        [JsonProperty("geographicalAreaServed")]
        public List<GeographicalAreaServed> GeographicalAreaServed { get; set; }
    }

    public class EdiInformation
    {
        [JsonProperty("ediInformationFlag")]
        public string EdiInformationFlag { get; set; }
    }

    public class Assertions
    {
        [JsonProperty("goodsAndServices")]
        public GoodsAndServices GoodsAndServices { get; set; }

        [JsonProperty("disasterReliefData")]
        public DisasterReliefData DisasterReliefData { get; set; }

        [JsonProperty("ediInformation")]
        public EdiInformation EdiInformation { get; set; }
    }

    public class ListOfProvision
    {
        [JsonProperty("provisionId")]
        public string ProvisionId { get; set; }
    }

    public class ListOfAnswer
    {
        [JsonProperty("answerType")]
        public string AnswerType { get; set; }

        [JsonProperty("answerId")]
        public string AnswerId { get; set; }

        [JsonProperty("answerText")]
        public string AnswerText { get; set; }

        [JsonProperty("businessObjectType")]
        public string BusinessObjectType { get; set; }

        [JsonProperty("businessObjectId")]
        public string BusinessObjectId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("hasSizeProtest")]
        public string HasSizeProtest { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("section")]
        public string Section { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("organizationType")]
        public string OrganizationType { get; set; }

        [JsonProperty("endProductName")]
        public string EndProductName { get; set; }

        [JsonProperty("endProductType")]
        public string EndProductType { get; set; }

        [JsonProperty("endProductCountry")]
        public string EndProductCountry { get; set; }

        [JsonProperty("placeOfManufacture")]
        public string PlaceOfManufacture { get; set; }

        [JsonProperty("fscCode")]
        public string FscCode { get; set; }

        [JsonProperty("environmentURL")]
        public string EnvironmentURL { get; set; }

        [JsonProperty("facilityStreetAddress1")]
        public string FacilityStreetAddress1 { get; set; }

        [JsonProperty("facilityStreetAddress2")]
        public string FacilityStreetAddress2 { get; set; }

        [JsonProperty("facilityCity")]
        public string FacilityCity { get; set; }

        [JsonProperty("facilityPostalCode")]
        public string FacilityPostalCode { get; set; }

        [JsonProperty("facilityState")]
        public string FacilityState { get; set; }

        [JsonProperty("facilityCountry")]
        public string FacilityCountry { get; set; }

        [JsonProperty("facilityOwner")]
        public string FacilityOwner { get; set; }

        [JsonProperty("facilityOwnerStreetAddress1")]
        public string FacilityOwnerStreetAddress1 { get; set; }

        [JsonProperty("facilityOwnerStreetAddress2")]
        public string FacilityOwnerStreetAddress2 { get; set; }

        [JsonProperty("facilityOwnerCity")]
        public string FacilityOwnerCity { get; set; }

        [JsonProperty("facilityOwnerPostalCode")]
        public string FacilityOwnerPostalCode { get; set; }

        [JsonProperty("facilityOwnerState")]
        public string FacilityOwnerState { get; set; }

        [JsonProperty("facilityOwnerCountry")]
        public string FacilityOwnerCountry { get; set; }

        [JsonProperty("immediateOwnerLegalBusinessName")]
        public string ImmediateOwnerLegalBusinessName { get; set; }

        [JsonProperty("immediateOwnerCageCode")]
        public string ImmediateOwnerCageCode { get; set; }

        [JsonProperty("highestOwnerLegalBusinessName")]
        public string HighestOwnerLegalBusinessName { get; set; }

        [JsonProperty("highestOwnerCageCode")]
        public string HighestOwnerCageCode { get; set; }

        [JsonProperty("firstPredecessorLegalBusinessName")]
        public string FirstPredecessorLegalBusinessName { get; set; }

        [JsonProperty("firstPredecessorCageCode")]
        public string FirstPredecessorCageCode { get; set; }

        [JsonProperty("secondPredecessorLegalBusinessName")]
        public string SecondPredecessorLegalBusinessName { get; set; }

        [JsonProperty("secondPredecessorCageCode")]
        public string SecondPredecessorCageCode { get; set; }

        [JsonProperty("thirdPredecessorLegalBusinessName")]
        public string ThirdPredecessorLegalBusinessName { get; set; }

        [JsonProperty("thirdPredecessorCageCode")]
        public string ThirdPredecessorCageCode { get; set; }

        [JsonProperty("primaryNaics")]
        public string PrimaryNaics { get; set; }

        [JsonProperty("naicsCode")]
        public string NaicsCode { get; set; }

        [JsonProperty("sbaSmallBusiness")]
        public string SbaSmallBusiness { get; set; }

        [JsonProperty("smallBusiness")]
        public string SmallBusiness { get; set; }

        [JsonProperty("veteranOwnedSmallBusiness")]
        public string VeteranOwnedSmallBusiness { get; set; }

        [JsonProperty("serviceDisabledVetOwnedSmallBusiness")]
        public string ServiceDisabledVetOwnedSmallBusiness { get; set; }

        [JsonProperty("womenOwnedSmallBusinessConcern")]
        public string WomenOwnedSmallBusinessConcern { get; set; }

        [JsonProperty("womenOwnedSmallBusiness")]
        public string WomenOwnedSmallBusiness { get; set; }

        [JsonProperty("economicallyDisadvWomenOwnedSmallBusiness")]
        public string EconomicallyDisadvWomenOwnedSmallBusiness { get; set; }

        [JsonProperty("smallDisadvantagedBusinessConcern")]
        public string SmallDisadvantagedBusinessConcern { get; set; }

        [JsonProperty("sbaCertifiedSmallBusinessDisadvBusiness")]
        public string SbaCertifiedSmallBusinessDisadvBusiness { get; set; }

        [JsonProperty("sbaCertifiedSmallBusinessDisadvBusinessNotSubmitted")]
        public string SbaCertifiedSmallBusinessDisadvBusinessNotSubmitted { get; set; }

        [JsonProperty("hubZoneSmallBusinessConcern")]
        public string HubZoneSmallBusinessConcern { get; set; }

        [JsonProperty("blackAmericanOwned")]
        public string BlackAmericanOwned { get; set; }

        [JsonProperty("hispanicAmericanOwned")]
        public string HispanicAmericanOwned { get; set; }

        [JsonProperty("nativeAmericanOwned")]
        public string NativeAmericanOwned { get; set; }

        [JsonProperty("asianPacificAmericanOwned")]
        public string AsianPacificAmericanOwned { get; set; }

        [JsonProperty("subcontinentAsianIndianAmericanOwned")]
        public string SubcontinentAsianIndianAmericanOwned { get; set; }

        [JsonProperty("historicallyBlackCollegeOrUniversity")]
        public string HistoricallyBlackCollegeOrUniversity { get; set; }

        [JsonProperty("minorityInstitution")]
        public string MinorityInstitution { get; set; }

        [JsonProperty("linkForFARReportPDF")]
        public string LinkForFARReportPDF { get; set; }

        [JsonProperty("linkForFARReportHTML")]
        public string LinkForFARReportHTML { get; set; }

        [JsonProperty("foreignGovernmentOwnershipFirstName")]
        public string ForeignGovernmentOwnershipFirstName { get; set; }

        [JsonProperty("foreignGovernmentOwnershipMiddleInitial")]
        public string ForeignGovernmentOwnershipMiddleInitial { get; set; }

        [JsonProperty("foreignGovernmentOwnershipLastName")]
        public string ForeignGovernmentOwnershipLastName { get; set; }

        [JsonProperty("foreignGovernmentOwnershipPhoneNum")]
        public string ForeignGovernmentOwnershipPhoneNum { get; set; }

        [JsonProperty("foreignGovernmentOwnershipPhoneExt")]
        public string ForeignGovernmentOwnershipPhoneExt { get; set; }

        [JsonProperty("foreignGovernmentOwnershipInternationalNum")]
        public string ForeignGovernmentOwnershipInternationalNum { get; set; }

        [JsonProperty("foreignGovernmentControlCountry")]
        public string ForeignGovernmentControlCountry { get; set; }

        [JsonProperty("foreignEndProductName")]
        public string ForeignEndProductName { get; set; }

        [JsonProperty("foreignEndProductCountry")]
        public string ForeignEndProductCountry { get; set; }

        [JsonProperty("linkForDFARSReportPDF")]
        public string LinkForDFARSReportPDF { get; set; }

        [JsonProperty("linkForDFARSReportHTML")]
        public string LinkForDFARSReportHTML { get; set; }

        [JsonProperty("middleInitial")]
        public string MiddleInitial { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("companyEstablishedYear")]
        public string CompanyEstablishedYear { get; set; }

        [JsonProperty("companyDUNS")]
        public string CompanyDUNS { get; set; }

        [JsonProperty("companyIsReference")]
        public string CompanyIsReference { get; set; }

        [JsonProperty("firmNumOfEmployees")]
        public string FirmNumOfEmployees { get; set; }

        [JsonProperty("branchNumOfEmployees")]
        public string BranchNumOfEmployees { get; set; }

        [JsonProperty("experienceCode")]
        public string ExperienceCode { get; set; }

        [JsonProperty("annualAvgRevenueCode")]
        public string AnnualAvgRevenueCode { get; set; }

        [JsonProperty("federalRevenueCode")]
        public string FederalRevenueCode { get; set; }

        [JsonProperty("nonFedRevenueCode")]
        public string NonFedRevenueCode { get; set; }

        [JsonProperty("totalRevenueCode")]
        public string TotalRevenueCode { get; set; }

        [JsonProperty("qualificationURLPDF")]
        public string QualificationURLPDF { get; set; }

        [JsonProperty("qualificationURLHTML")]
        public string QualificationURLHTML { get; set; }
    }

    public class FARRespons
    {
        [JsonProperty("listOfProvisions")]
        public List<ListOfProvision> ListOfProvisions { get; set; }

        [JsonProperty("listOfAnswers")]
        public List<ListOfAnswer> ListOfAnswers { get; set; }
    }

    public class DFARRespons
    {
        [JsonProperty("listOfProvisions")]
        public List<ListOfProvision> ListOfProvisions { get; set; }

        [JsonProperty("listOfAnswers")]
        public List<ListOfAnswer> ListOfAnswers { get; set; }
    }

    public class Certifications
    {
        [JsonProperty("fARResponses")]
        public List<FARRespons> FARResponses { get; set; }

        [JsonProperty("dFARResponses")]
        public List<DFARRespons> DFARResponses { get; set; }
    }

    public class ArchitectEngineerResponses
    {
        [JsonProperty("listOfProvisions")]
        public List<ListOfProvision> ListOfProvisions { get; set; }

        [JsonProperty("listOfAnswers")]
        public List<ListOfAnswer> ListOfAnswers { get; set; }
    }

    public class Qualifications
    {
        [JsonProperty("architectEngineerResponses")]
        public ArchitectEngineerResponses ArchitectEngineerResponses { get; set; }
    }

    public class FinancialAssistanceCertifications
    {
        [JsonProperty("financialAssistanceResponse")]
        public string FinancialAssistanceResponse { get; set; }
    }

    public class RepsAndCerts
    {
        [JsonProperty("certifications")]
        public Certifications Certifications { get; set; }

        [JsonProperty("qualifications")]
        public Qualifications Qualifications { get; set; }

        [JsonProperty("financialAssistanceCertifications")]
        public FinancialAssistanceCertifications FinancialAssistanceCertifications { get; set; }
    }

    public class GovernmentBusinessPOC
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("middleInitial")]
        public object MiddleInitial { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("usPhone")]
        public object UsPhone { get; set; }

        [JsonProperty("usPhoneExtension")]
        public object UsPhoneExtension { get; set; }

        [JsonProperty("nonUSPhone")]
        public string NonUSPhone { get; set; }

        [JsonProperty("fax")]
        public object Fax { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public object AddressLine2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("stateOrProvinceCode")]
        public string StateOrProvinceCode { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("zipCodePlus4")]
        public object ZipCodePlus4 { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }

    public class ElectronicBusinessPOC
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("middleInitial")]
        public object MiddleInitial { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("usPhone")]
        public object UsPhone { get; set; }

        [JsonProperty("usPhoneExtension")]
        public object UsPhoneExtension { get; set; }

        [JsonProperty("nonUSPhone")]
        public string NonUSPhone { get; set; }

        [JsonProperty("fax")]
        public object Fax { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public object AddressLine2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("stateOrProvinceCode")]
        public string StateOrProvinceCode { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("zipCodePlus4")]
        public object ZipCodePlus4 { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }

    public class GovernmentBusinessAlternatePOC
    {
        [JsonProperty("firstName")]
        public object FirstName { get; set; }

        [JsonProperty("middleInitial")]
        public object MiddleInitial { get; set; }

        [JsonProperty("lastName")]
        public object LastName { get; set; }

        [JsonProperty("title")]
        public object Title { get; set; }

        [JsonProperty("usPhone")]
        public object UsPhone { get; set; }

        [JsonProperty("usPhoneExtension")]
        public object UsPhoneExtension { get; set; }

        [JsonProperty("nonUSPhone")]
        public object NonUSPhone { get; set; }

        [JsonProperty("fax")]
        public object Fax { get; set; }

        [JsonProperty("email")]
        public object Email { get; set; }

        [JsonProperty("addressLine1")]
        public object AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public object AddressLine2 { get; set; }

        [JsonProperty("city")]
        public object City { get; set; }

        [JsonProperty("stateOrProvinceCode")]
        public object StateOrProvinceCode { get; set; }

        [JsonProperty("zipCode")]
        public object ZipCode { get; set; }

        [JsonProperty("zipCodePlus4")]
        public object ZipCodePlus4 { get; set; }

        [JsonProperty("countryCode")]
        public object CountryCode { get; set; }
    }

    public class ElectronicBusinessAlternatePOC
    {
        [JsonProperty("firstName")]
        public object FirstName { get; set; }

        [JsonProperty("middleInitial")]
        public object MiddleInitial { get; set; }

        [JsonProperty("lastName")]
        public object LastName { get; set; }

        [JsonProperty("title")]
        public object Title { get; set; }

        [JsonProperty("usPhone")]
        public object UsPhone { get; set; }

        [JsonProperty("usPhoneExtension")]
        public object UsPhoneExtension { get; set; }

        [JsonProperty("nonUSPhone")]
        public object NonUSPhone { get; set; }

        [JsonProperty("fax")]
        public object Fax { get; set; }

        [JsonProperty("email")]
        public object Email { get; set; }

        [JsonProperty("addressLine1")]
        public object AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public object AddressLine2 { get; set; }

        [JsonProperty("city")]
        public object City { get; set; }

        [JsonProperty("stateOrProvinceCode")]
        public object StateOrProvinceCode { get; set; }

        [JsonProperty("zipCode")]
        public object ZipCode { get; set; }

        [JsonProperty("zipCodePlus4")]
        public object ZipCodePlus4 { get; set; }

        [JsonProperty("countryCode")]
        public object CountryCode { get; set; }
    }

    public class PastPerformancePOC
    {
        [JsonProperty("firstName")]
        public object FirstName { get; set; }

        [JsonProperty("middleInitial")]
        public object MiddleInitial { get; set; }

        [JsonProperty("lastName")]
        public object LastName { get; set; }

        [JsonProperty("title")]
        public object Title { get; set; }

        [JsonProperty("usPhone")]
        public object UsPhone { get; set; }

        [JsonProperty("usPhoneExtension")]
        public object UsPhoneExtension { get; set; }

        [JsonProperty("nonUSPhone")]
        public object NonUSPhone { get; set; }

        [JsonProperty("fax")]
        public object Fax { get; set; }

        [JsonProperty("email")]
        public object Email { get; set; }

        [JsonProperty("addressLine1")]
        public object AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public object AddressLine2 { get; set; }

        [JsonProperty("city")]
        public object City { get; set; }

        [JsonProperty("stateOrProvinceCode")]
        public object StateOrProvinceCode { get; set; }

        [JsonProperty("zipCode")]
        public object ZipCode { get; set; }

        [JsonProperty("zipCodePlus4")]
        public object ZipCodePlus4 { get; set; }

        [JsonProperty("countryCode")]
        public object CountryCode { get; set; }
    }

    public class PastPerformanceAlternatePOC
    {
        [JsonProperty("firstName")]
        public object FirstName { get; set; }

        [JsonProperty("middleInitial")]
        public object MiddleInitial { get; set; }

        [JsonProperty("lastName")]
        public object LastName { get; set; }

        [JsonProperty("title")]
        public object Title { get; set; }

        [JsonProperty("usPhone")]
        public object UsPhone { get; set; }

        [JsonProperty("usPhoneExtension")]
        public object UsPhoneExtension { get; set; }

        [JsonProperty("nonUSPhone")]
        public object NonUSPhone { get; set; }

        [JsonProperty("fax")]
        public object Fax { get; set; }

        [JsonProperty("email")]
        public object Email { get; set; }

        [JsonProperty("addressLine1")]
        public object AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public object AddressLine2 { get; set; }

        [JsonProperty("city")]
        public object City { get; set; }

        [JsonProperty("stateOrProvinceCode")]
        public object StateOrProvinceCode { get; set; }

        [JsonProperty("zipCode")]
        public object ZipCode { get; set; }

        [JsonProperty("zipCodePlus4")]
        public object ZipCodePlus4 { get; set; }

        [JsonProperty("countryCode")]
        public object CountryCode { get; set; }
    }

    public class PointsOfContact
    {
        [JsonProperty("governmentBusinessPOC")]
        public GovernmentBusinessPOC GovernmentBusinessPOC { get; set; }

        [JsonProperty("electronicBusinessPOC")]
        public ElectronicBusinessPOC ElectronicBusinessPOC { get; set; }

        [JsonProperty("governmentBusinessAlternatePOC")]
        public GovernmentBusinessAlternatePOC GovernmentBusinessAlternatePOC { get; set; }

        [JsonProperty("electronicBusinessAlternatePOC")]
        public ElectronicBusinessAlternatePOC ElectronicBusinessAlternatePOC { get; set; }

        [JsonProperty("pastPerformancePOC")]
        public PastPerformancePOC PastPerformancePOC { get; set; }

        [JsonProperty("pastPerformanceAlternatePOC")]
        public PastPerformanceAlternatePOC PastPerformanceAlternatePOC { get; set; }
    }

    public class EntityData
    {
        [JsonProperty("entityRegistration")]
        public EntityRegistration EntityRegistration { get; set; }

        [JsonProperty("coreData")]
        public CoreData CoreData { get; set; }

        [JsonProperty("assertions")]
        public Assertions Assertions { get; set; }

        [JsonProperty("repsAndCerts")]
        public RepsAndCerts RepsAndCerts { get; set; }

        [JsonProperty("pointsOfContact")]
        public PointsOfContact PointsOfContact { get; set; }
    }

    public class Links
    {
        [JsonProperty("selfLink")]
        public string SelfLink { get; set; }
    }

    public class ApiResponse
    {
        [JsonProperty("totalRecords")]
        public int TotalRecords { get; set; }

        [JsonProperty("entityData")]
        public List<EntityData> EntityData { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }
    }



}