import React from "react";
import {
  BrowserRouter as Router,
  Switch,
  Route,
  Link
} from "react-router-dom";
import AddUser from "../api/AddUser";
import AllUser from "../api/AllUser";

export default function AppRoute() {
    return (
      <Router>
        <div>
          <nav>
            <ul>
              <li>
                <Link to="/">Add</Link>
              </li>
              <li>
                <Link to="/users">Users</Link>
              </li>
            </ul>
          </nav>
  
          <Switch>
            <Route path="/users">
              <AllUser />
            </Route>
            <Route path="/">
              <AddUser />
            </Route>
          </Switch>
        </div>
      </Router>
    );
  }
  