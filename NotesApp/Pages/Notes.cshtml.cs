using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class NotesModel : PageModel
{
    public static List<string> Notes { get; set; } = new List<string>();

    [BindProperty]
    public string NewNote { get; set; }

    [BindProperty]
    public string NoteToDelete { get; set; }

    [BindProperty]
    public string NoteToEdit { get; set; }

    [BindProperty]
    public string OriginalNote { get; set; }

    [BindProperty]
    public string UpdatedNote { get; set; }

    public string NoteBeingEdited { get; set; }

    public void OnGet()
    {
        // Display notes
    }

    public IActionResult OnPost()
    {
        // Add a new note
        if (!string.IsNullOrEmpty(NewNote))
        {
            Notes.Add(NewNote);
        }
        return RedirectToPage();
    }

    public IActionResult OnPostDelete()
    {
        // Delete a note
        if (!string.IsNullOrEmpty(NoteToDelete))
        {
            Notes.Remove(NoteToDelete);
        }
        return RedirectToPage();
    }

    public IActionResult OnPostStartEdit()
    {
        // Begin editing a note
        NoteBeingEdited = NoteToEdit;
        return Page();
    }

    public IActionResult OnPostEdit()
    {
        // Save the updated note
        if (!string.IsNullOrEmpty(OriginalNote) && !string.IsNullOrEmpty(UpdatedNote))
        {
            int index = Notes.IndexOf(OriginalNote);
            if (index >= 0)
            {
                Notes[index] = UpdatedNote;
            }
        }
        return RedirectToPage();
    }
}
