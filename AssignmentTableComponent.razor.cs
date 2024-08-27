using Microsoft.AspNetCore.Components;

namespace AssignmentTable
{
    public partial class AssignmentTableComponent
    {
        [Parameter]
        public bool IsDarkTheme { get; set; } = true;

        [Parameter]
        public IEnumerable<Assignment> Assignments { get; set; } = Enumerable.Empty<Assignment>();


        private string TableClass => IsDarkTheme ? "table-dark" : "table-light";
    }
}