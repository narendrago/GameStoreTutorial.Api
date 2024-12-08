namespace GameStore.Api.Dtos;

/*we are using records instead of classes
because records are immutable meaning
their properties cannot be changed once set while creating record
so record is ideal for Dtos as they are just objects that transfer
data and do not change any values anywhere
*/
public record class GameSummaryDto(
    int Id,
    string Name,
    string Genre,
    decimal Price,
    DateOnly ReleaseDate); // Represents only Date