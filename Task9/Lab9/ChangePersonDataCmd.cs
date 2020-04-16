namespace Labs
{
    public class ChangePersonDataCmd : AbstractCommand
    {
        private Person _temporaryUser;
        private Person _personReference;


        public ChangePersonDataCmd(Person person)
        {
            _temporaryUser = (Person)person.Clone();
            _personReference = person;
        }

        public override void doit()
        {
            UpdateUser();
        }

        public override void undo()
        {
            UpdateUser();
        }

        public override void redo()
        {
            doit();
        }

        private void UpdateUser()
        {
            // _personReference is the changed user: user1
            Person _tempPerson = (Person)_personReference.Clone();
            // set user1 to the previous value of user(this is same for undo/redo)
            SetPersonValues();
            // after we changed the _personReference value, set _temporaryUser to
            // the value of _perfonReference before we changed it(user1)
            _temporaryUser = _tempPerson;
            // display the view
            UpdateView();
        }

        private void SetPersonValues()
        {
            _personReference.Name = _temporaryUser.Name;
            _personReference.LastName = _temporaryUser.LastName;
            _personReference.Age = _temporaryUser.Age;
            _personReference.City = _temporaryUser.City;
        }

        private void UpdateView()
        {
            _personReference.updateTreeText();

            AppForm.getAppForm().MyTreeView.SelectedNode = _temporaryUser;
        }

    }
}
