namespace GameStore.Api.Dtos;

/*we are using records instead of classes
because records are immutable meaning
their properties cannot be changed once set while creating record
so record is ideal for Dtos as they are just objects that transfer
data and do not change any values anywhere
*/
public record class GameDetailsDto(
    int Id,
    string Name,
    int GenreId,
    decimal Price,
    DateOnly ReleaseDate); // Represents only Date