using System.Text.Json;
using API.Helpers;

namespace API.Extentions
{
    public static class HttpExtentions
    {
        public static void AddPagination(this HttpResponse response, int currentPage, PaginationHeader header)
        {
            var jsonOptions = new JsonSerializerOptions{PropertyNamingPolicy = JsonNamingPolicy.CamelCase};
            response.Headers.Append("Pagination", JsonSerializer.Serialize(header, jsonOptions));
            response.Headers.Append("Access-Control-Expose-Headers", "Pagination");
        }
    }
}