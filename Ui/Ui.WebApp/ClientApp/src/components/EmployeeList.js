import React, { Component } from 'react';

export class EmplyoeeList extends Component {
  static displayName = EmplyoeeList.name;

  constructor(props) {
    super(props);
    this.state = { employees: [], loading: true };
  }

  componentDidMount() {
    this.getData();
  }

  static renderTable(employees) {
    return (
      <table className='table table-striped' aria-labelledby="tableLabel">
        <thead>
          <tr>
            <th>Vorname</th>
            <th>Zuname</th>
          </tr>
        </thead>
        <tbody>
          {employees.map(emp =>
            <tr key={emp.id}>
              <td>{emp.firstname}</td>
              <td>{emp.lastname}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : EmplyoeeList.renderTable(this.state.employees);

    return (
      <div>
        <h1 id="tableLabel">Mitarbeiter</h1>
        <p>Liste aller Mitarbeiter.</p>
        {contents}
      </div>
    );
  }

  async getData() {
    const response = await fetch('api/employee');
    const data = await response.json();
    this.setState({ employees: data, loading: false });
  }
}
