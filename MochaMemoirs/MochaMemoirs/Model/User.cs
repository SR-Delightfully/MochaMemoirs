using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MochaMemoirs.Model;

//TODO 3. create methods that call the database
//TODO 4. create login form
//TODO 5. connect login form to handleLogin() method
//TODO 6. connect methods to rest of the form

public class User {
    private string        email;
    private List<Library> libraries;
    private string        password;

    //CONSTRUCTORS & PROPERTIES/////////////////////////////////////////////////////////////////////////////////////////
    public User(string user_id, string name, string email, string password, List<Library> libraries) {
        this.UserId    = user_id;
        this.Name      = name;
        this.Email     = email;
        this.Password  = password;
        this.Libraries = libraries;
    }

    public string UserId { get; set; }

    public string Name { get; set; }

    public string Email {
        get => email;
        set => email = !value.Contains("@") ? null : value;
    }

    public string Password {
        get => password;
        set => password = isValidPassword(value) ? value : null;
    }

    public List<Library> Libraries {
        get => libraries;
        set => libraries = (value == null || !value.Any() || value is IList) ? [] : value;
    }

    //HELPER METHODS////////////////////////////////////////////////////////////////////////////////////////////////////
    protected bool isValidPassword(string tryPassword) {
        var numberCounter           = 0;
        var capitalLetterCounter    = 0;
        var specialCharacterCounter = 0;

        if (tryPassword.Contains(';') || tryPassword.Contains('"') || tryPassword.Contains('/')) {
            Console.WriteLine("[ERROR : Password cannot contain ';', '\"', or '/' ]");
            return false;
        }

        for (var i = 0; i < tryPassword.Length; i++) {
            numberCounter           += password[i] >= '0' && password[i] <= '9' ? 1 : 0;
            capitalLetterCounter    += password[i] >= 'A' && password[i] <= 'Z' ? 1 : 0;
            specialCharacterCounter += password[i] >= 'a' && password[i] <= 'z' ? 1 : 0;
        }

        if (numberCounter > 0 || capitalLetterCounter > 0 || specialCharacterCounter > 0) return true;

        return false;
    }

    public void addLibrary(List<Book> books) {
        if (books != null || books.Any())
            libraries.Add(new Library(books));
        else
            libraries.Add(new Library());
    }
}
