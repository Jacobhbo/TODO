namespace TODO
{
    /*
 * To do item
 *  Date Created
 *  Date Deadline
 *  Do / Done
 *  Favorite
 *  What to do Text
 *  Repeat
 *  
 *  Create/Read/Update/Delete
 * */
    internal class ToDoItem
    {
        public DateTime Created { get; set; } //Time created
        public DateTime? Deadline { get; set; } //Deadline for doing
        public bool IsDone { get; set; } //Is it done?
        public bool IsFavorite { get; set; } //When list of Todo items is shown, favorites should be on top
        public string Todo { get; set; } // What to do
        public long Repeat { get; set; } //If repeat > 0 then repeat is on. long is datetime ticks
        public string? Description { get; internal set; }
    }
}